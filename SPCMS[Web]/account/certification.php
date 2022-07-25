<?php
require_once '../core/initInternal.php';

  if(!Session::exists('user')){
    Redirect::to('Login-form.php');
  }

$upload = new Upload();

if(isset($_POST['submit']))
{
  ## -- INSERTING PAYMENT METHOD
  $payment_id = '';
  $sowing_id = '';
  if(Input::get('paymentMethodOption') == 1)
  {
    DB::getInstance()->insert('payment_details', array(
                'method_id' => Input::get('paymentMethodOption'),
                'customer_id' => Session::get('customer_id'),
                'bank_id' => Input::get('bank-service')
              ));
   $payment_id = DB::getInstance()->lastid();
   $upload->upload('deposit_slip/','payment_details','bank_deposit_slip','payment_id',$payment_id,'deposit-slip');
  }
  else
  {
    DB::getInstance()->insert('payment_details', array(
                  'method_id' => Input::get('paymentMethodOption'),
                  'customer_id' => Session::get('customer_id'),
                  'service_id' => Input::get('mobile-service'),
                  'transaction_id' => Input::get('referenceNo')
                ));
    $payment_id = DB::getInstance()->lastid();
  }

  ## -- INSERTING SOWING REPORT
  DB::getInstance()->insert('sowing_report', array(
                'customer_id' => Session::get('customer_id'),
                'crop_id' => Input::get('crop'),
                'variety_id' => Input::get('variety'),
                'class_id' => Input::get('seedClass'),
                'payment_id' => $payment_id,
                'seed_source' => Input::get('srcSeed'),
                'tag_number' => Input::get('tagNo'),
                'purchase_bill_no' => Input::get('billNo'),
                'date_of_purchase' => Input::get('date-of-purchase'),
                'quantity_per_acrea' => Input::get('quantity'),
                'acreage' => Input::get('acreage'),
                'date_of_sowing' => Input::get('date-of-sowing'),
                'status' => 'Pending'
              ));
  $sowing_id = DB::getInstance()->lastid();
  $upload->upload('enclosures/','sowing_report','tagSrc','sowing_id',$sowing_id,'tag-source');
  $upload->upload('enclosures/','sowing_report','purchaseBill','sowing_id',$sowing_id,'purchase-bill');



  Redirect::to('certification.php');
}

if(isset($_POST['submit-edit']))
{

  ## -- UPDATING PAYMENT METHOD
  $payment_id = Input::get('payment_id');
  $sowing_id = Input::get('primarykey');


  if(Input::get('paymentMethodOption') == 1)
  {
    DB::getInstance()->update('payment_details', 'payment_id', $payment_id, array(
                'method_id' => Input::get('paymentMethodOption'),
                'bank_id' => Input::get('bank-service')
              ));
    if(isset($_FILES['bank_deposit_slip'])){
      $upload->upload('deposit_slip/','payment_details','bank_deposit_slip','payment_id',$payment_id,'deposit-slip');
    }
  }
  else
  {

    $update = DB::getInstance()->update('payment_details', 'payment_id', $payment_id ,array(
                  'method_id' => Input::get('paymentMethodOption'),
                  'service_id' => Input::get('mobile-service'),
                  'transaction_id' => Input::get('referenceNo')
                ));
  }

  ## -- UPDATING SOWING REPORT
  DB::getInstance()->update('sowing_report', 'sowing_id', $sowing_id, array(
                'crop_id' => Input::get('crop'),
                'variety_id' => Input::get('variety'),
                'class_id' => Input::get('seedClass'),
                'seed_source' => Input::get('srcSeed'),
                'tag_number' => Input::get('tagNo'),
                'purchase_bill_no' => Input::get('billNo'),
                'date_of_purchase' => Input::get('date-of-purchase'),
                'quantity_per_acrea' => Input::get('quantity'),
                'acreage' => Input::get('acreage'),
                'date_of_sowing' => Input::get('date-of-sowing')
              ));
  if (isset($_FILES['tag-source'])) {
    $upload->upload('enclosures/','sowing_report','tagSrc','sowing_id',$sowing_id,'tag-source');
  } else if(isset($_FILES['purchase-bill'])){
    $upload->upload('enclosures/','sowing_report','purchaseBill','sowing_id',$sowing_id,'purchase-bill');
  }
  Redirect::to('certification.php');
}



function Load_Crop()
{
  $output = DB::getInstance()->query('SELECT * FROM crop');
  $crop = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $crop .= '<option value="'.$output->crop_id.'">'.$output->crop_name.'</option>';
    }
  }
  return $crop;
}


function Load_Class()
{
  $output = DB::getInstance()->query('SELECT * FROM class');
  $class = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $class .= '<option value="'.$output->class_id.'">'.$output->class_name.' - '.$output->genetic_purity.' Genetic Purity</option>';
    }
  }
  return $class;
}


function Load_MobilePayment()
{
  $output = DB::getInstance()->query('SELECT * FROM mobile_service');
  $service = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $service .= '<option value="'.$output->service_id.'">'.$output->service_name.'</option>';
    }
  }
  return $service;
}

function Load_BankPayment()
{
  $output = DB::getInstance()->query('SELECT * FROM bank_service');
  $service = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $service .= '<option value="'.$output->bank_id.'"> '.$output->bank_name.': '.$output->account_number.' </option>';
    }
  }
  return $service;
}

function Load_Sowing_Report($_id)
{
  $output = DB::getInstance()->get('sowing_report', array('customer_id' ,'=' , $_id));
  $sowing_report = '';

  if($output->count() > 0)
  {
    foreach ($output->results() as $output)
    {
      $sowing_report .= '<div class="col-lg-5 col-md-5 col-sm-12 col-xs-12 crop-container">
      <div class="crop-name-container">';
      $crop_output = DB::getInstance()->get('crop',array('crop_id','=', $output->crop_id));
      if($crop_output)
      {
        foreach ($crop_output->results() as $opt)
        {
          $sowing_report .= '<h3>'.$opt->crop_name.'</h3>';
        }
      }else{$sowing_report .= '<h3>N/A</h3>';}

      $cert_output = DB::getInstance()->get('certification_number',array('certification_id','=', $output->certification_id));
      if($cert_output->count() > 0)
      {
        foreach ($cert_output as $opt) {
          $sowing_report .='<h5>CERTIFICATION NO.: '.$opt->certification_no.'</h5>';
        }
      }else{$sowing_report .='<h5>CERTIFICATION NO.: N/A</h5>';}

      $inspection_output = DB::getInstance()->get('certification_number',array('certification_id','=', $output->certification_id));
      if($inspection_output)
      {
        $sowing_report .= '<a href="#">Field Inspection Conducted &nbsp;&nbsp;<span class="badge">'.$inspection_output->count().'</span></a>';
      }else
      {
        $sowing_report .= '<a href="#">Field Inspection Conducted &nbsp;&nbsp;<span class="badge">0</span></a>';
      }

      $sowing_report .= '</div>
      <div style="padding: 10px;" class="crop-details">
        <table>';

      $variety_output = DB::getInstance()->get('variety',array('variety_id','=', $output->variety_id));
      if($variety_output)
      {
        foreach ($variety_output->results() as $opt) {
          $sowing_report .= '<tr><td>Variety:</td><td> '.$opt->variety_name.'</td></tr>';
        }
      }else{$sowing_report .= '<tr><td>Variety:</td><td> N/A</td></tr>';}

      $sowing_report .= '<tr><td>Acreage:</td><td> '.$output->acreage.'</td></tr>';
      $sowing_report .= '<tr><td>Location:</td><td> N/A</td></tr>';

      $class_output = DB::getInstance()->get('class',array('class_id','=', $output->class_id));
      if($class_output)
      {
        foreach ($class_output->results() as $opt)
        {
          $sowing_report .= '<tr><td>Class of Seed to <br>be Produced:</td><td> '.$opt->class_name.': '.$opt->genetic_purity.'</td></tr>';
        }
      }
      else
      {
          $sowing_report .= '<tr><td>Class of Seed to be<br>Produced:</td><td> N/A</td></tr>';
      }

      $sowing_report .= '<tr><td>Quantity of Seeds<br>used (kg/acre):</td><td> '.$output->quantity_per_acrea.'</td></tr>';
      $sowing_report .='<tr><td>Date of Sowing:</td><td> '.$output->date_of_sowing.'</td></tr>
        <tr><th>Source of seed</th><th></th></tr>
        <tr><td>Source:</td><td> '.$output->seed_source.'</td></tr>
        <tr><td>Tag Number:</td><td> '.$output->tag_number.'</td></tr>
        <tr><td>Purchase Bill No.:</td><td> '.$output->purchase_bill_no.'</td></tr>
        <tr><td>Date:</td><td> '.$output->date_of_purchase.'</td></tr>
        <tr><th>Mode of Payment</th><th></th></tr>';

      $payment_ouptut = DB::getInstance()->get('payment_details',array('payment_id','=', $output->payment_id));
       if($payment_ouptut)
       {
          foreach ($payment_ouptut->results() as $opt) {
            if($opt->method_id == 1)
            {
              $bank_output = DB::getInstance()->get('bank_service',array('bank_id','=', $opt->bank_id));
              foreach ($bank_output->results() as $bank) {
                $sowing_report .= '<tr><td>Bank Deposit:</td>
                <td> Yes<br>Bank: '.$bank->bank_name.' - '.$bank->account_number.'<br>
                <a href="#" id="'.$output->payment_id.'.payment_id.payment_details.bank_deposit_slip.BANK DEPOSIT SLIP" class="open-view-image-container">View Deposit Slip</a></td></tr>';
                $sowing_report .= '<tr><td>Mobile Wallet:</td><td>No<br>Service: N/A<br>Trans ID: N/A</td></tr>';
              }

            }else
            {
              $mobile_service = DB::getInstance()->get('mobile_service',array('service_id','=', $opt->service_id));
                foreach ($mobile_service->results() as $mobile)
                {
                  $sowing_report .= '<tr><td>Bank Deposit:</td><td> No<br>Bank: N/A<br>N/A</td></tr>';
                    $sowing_report .= '<tr><td>Mobile Wallet:</td><td>Yes<br>Service: '.$mobile->service_name.': '.$mobile->contact.'<br>Trans ID: '.$opt->transaction_id.'</td></tr>';
                }
            }
          }
       }

       $sowing_report .= '<tr><th>Enclosures</th><th></th></tr>
                          <tr><td>Tag for source of<br>seed:</td>
                          <td><a href="#" id="'.$output->sowing_id.'.sowing_id.sowing_report.tagSrc.TAG SOURCE" class="open-view-image-container">View Tag</a></td>
                          </tr>
                          <tr><td>Purchase bill</td>
            <td><a href="#" id ="'.$output->sowing_id.'.sowing_id.sowing_report.purchaseBill..PURCHASE BILL" class="open-view-image-container">View Purchase Bill</a></td>
          </tr>
        </table>
      </div>

      <a href="#" class="open-edit-sowing-report '.$output->sowing_id.'" id="btn">Edit</a>
      </div>';
     }
   }

  return $sowing_report;
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <link rel="stylesheet" type="text/css" href="../css/fonts/font-awesome/css/font-awesome.css">
  <link rel="stylesheet" type="text/css" href="../css/animation/animate.css">
  <link rel="stylesheet" type="text/css" href="../css/bootstrap/bootstrap.min.css">
  <link rel="stylesheet" type="text/css" href="../css/bootstrap/bootstrap-theme.min.css">

  <link rel="stylesheet" type="text/css" href="../css/account.css">
  <link rel="stylesheet" type="text/css" href="../css/customizables.css">
  <title>User Account | Seed Production</title>
</head>
<body>

<header class="_hearder">
  <ul class="home-container">
    <li class="home-btn"><a class="home-btn-link" href=""><i class="fa fa-home"></i></a></li>
    <p><a href="../BARS.html" class="home-link" style="text-decoration: none;">Home</a></p>
  </ul>

  <span class="menu-icon-account"><i class="fa fa-bars"></i></span>
  </header>

  <nav class="_vertical_nav">
    <div>
      <h3>User Account</h3>
      <ul class="menu-links">
        <a href="account.php">
          <i class="fa fa-history"></i>
          <li> &nbsp;&nbsp;&nbsp;Activities</li>
        </a>
        <a class="active-link" href="#">
          <i class="fa fa-certificate"></i>
          <li> &nbsp;&nbsp;&nbsp;Seed Certification</li>
        </a>
        <a href="request-inspection.php">
          <i class="fa fa-plus"></i>
          <li> &nbsp;&nbsp;&nbsp;Request Inspection</li>
        </a>
        <a href="logout.php">
          <i class="fa fa-sign-out"></i>
          <li> &nbsp;&nbsp;&nbsp;Log Out</li>
        </a>
      </ul>
  </div>
  </nav>

  <div class="main-container">
    <h4 style="margin-bottom: 40px;">
      <span class="user-name">Hi <span><?php echo Session::get("Username") ?></span></span>
    </h4>

    <div class="" style="">
      <p>To apply for Seed Certification please Fill in a SOWING REPORT</p>
      <a href="#" id="open-sowing-report" class="open-sowing-report">Sowing Report</a>
    </div>

    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-top: 30px">
      <?php echo Load_Sowing_Report(Session::get('customer_id'));  ?>

    </div>
  </div>

  <!-- SOWING REPORT FORM -->


  <div class="overlay-wrapper-sowing-report">
    <div class="overlay-wrapper-sowing-report-close-btn">
      <span class="close-sowing-report"><i class="fa fa-close" style="color: #FFFFFF;"></i></span>
    </div>
    <form role="form" style="margin-top: 40px;" method="POST" action=""  enctype="multipart/form-data" id="sowing-report-form" class="sowing-report-form" onsubmit="return ValidateSowingReport()">
      <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 form-content" style="background-color: rgb(223, 226, 214);">
        <div class="form-group">
          <h3 align="center" class="formTitle">SOWING REPORT</h3>
          <div class="col-lg-6">
            <h3>Seed and Land Details</h3>

            <label for="crop">Select Crop *</label>
            <span id="cropFailed" class="required-text"></span>
            <select name="crop" class="form-control" id="crop">
              <option value="" disabled selected hidden>Select Crop</option>
              <?php echo Load_Crop(); ?>
            </select>

            <label for="variety">Select Variety *</label>
            <span id="varietyFailed" class="required-text"></span>
            <select name="variety" class="form-control" id="variety">
              <option value="" disabled selected hidden>Select Variety</option>
            </select>

            <label for="seedClass">Class of Seed to be Produced *</label>
            <span id="seedClassFailed" class="required-text"></span>
            <select name="seedClass" class="form-control" id="seedClass">
              <option value="" disabled selected hidden>Select Class</option>
              <?php echo Load_Class(); ?>
            </select>

            <label for="srcSeed">Source of seed *</label>
            <span id="srcSeedFailed" class="required-text"></span>
            <input id="srcSeed" name="srcSeed" type="text" class="required form-control">

            <label for="tagNo">Tag number *</label>
            <span id="tagNoFailed" class="required-text"></span>
            <input id="tagNo" name="tagNo" type="text" class="required form-control">

            <label for="billNo">Purchase Bill No. *</label>
            <span id="billNoFailed" class="required-text"></span>
            <input id="billNo" name="billNo" type="text" class="required form-control">

            <label for="date-of-purchase">Date of Purchase *</label>
            <span id="date-of-purchaseFailed" class="required-text"></span>
            <input id="date-of-purchase" name="date-of-purchase" type="date" class="required form-control">

            <label for="quantity">Quantity of Seeds used (kg/acre) *</label>
            <span id="quantityFailed" class="required-text"></span>
            <input id="quantity" name="quantity" type="text" class="required form-control">

            <label for="acreage">Acreage *</label>
            <span id="acreageFailed" class="required-text"></span>
            <input id="acreage" name="acreage" type="text" class="required form-control" placeholder="For Example: 20">

            <label for="date-of-sowing">Date of Sowing *</label>
            <span id="date-of-sowingFailed" class="required-text"></span>
            <input id="date-of-sowing" name="date-of-sowing" type="date" class="required form-control"> <input id="primarykey" name="primarykey" type="hidden" class="required form-control">
            <input id="payment_id" name="payment_id" type="hidden" class="required form-control">
          </div>

          <div class="col-lg-6">
            <h3>Enclosures</h3>
            This includes: <b>Mode of fee payment</b>, proff of the <b>fee payment</b> to process the Sowing reporting, a <b>Scanned document</b> of the <b>Tag for the source of seed</b> and <b>Purchase bill of the seeds used</b>.<br><br>
            <b>NOTE:</b> If the payment was made through Our Bank Account please scan the deposit slip and send it to us for processing to verify your payment
              <br/><br/>
            <label for="">Mode of Payment *</label><br>

            <div class="radio">
              <label>
                <input type="radio" name="paymentMethodOption" value="1" id="bank-service"
                value="Bank Deposit" checked> Bank Deposit
              </label>
            </div>

            <div class="radio">
              <label>
                <input type="radio" name="paymentMethodOption" value="2" id="mobile-service"
                value="Mobile Wallet Services" > Mobile Wallet Services
              </label>
            </div>

            <div class="mobile-service" style="margin-bottom: 30px;">
              <label for="mobile-service">Mobile Service *</label>
              <span id="mobile-serviceFailed" class="required-text"></span>
              <select name="mobile-service" class="form-control" id="mobile-service-select">
              <option value="" disabled selected hidden>Select Service</option>
              <?php echo Load_MobilePayment(); ?>
              </select>


              <label for="referenceNo">Reference No./ Transaction ID *</label>
              <span id="referenceNoFailed" class="required-text"></span>
              <input id="referenceNo" name="referenceNo" type="text" class="required form-control">
            </div>

            <div class="mode-bank" style="margin-bottom: 30px;">

              <label for="bank-service">Bank Serivce *</label>
              <span id="bank-serviceFailed" class="required-text"></span>
              <select name="bank-service" class="form-control" id="bank-service-select">
              <option value="" disabled selected hidden>Select Service</option>
              <?php echo Load_BankPayment(); ?>
              </select>

              <label for="deposit-slip">Deposit Slip *</label>
              <span id="deposit-slipFailed" class="required-text"></span>
              <input id="deposit-slip" name="deposit-slip" type="file" accept="image/*" class="required form-control">
              <div id="bank_deposit_slip_thumbnail">
                <img id="thumbnail" class="thumbnail" src="">
              </div>
            </div>

            <div class="tag-bill">
              <label for="tag-source">Tag for source of seed *</label>
              <span id="tag-sourceFailed" class="required-text"></span>
              <input id="tag-source" name="tag-source" type="file" accept="image/*" class="required form-control">

              <div id="tag_thumbnail">
                <img id="thumbnail" class="thumbnail" src="">
              </div>

              <label for="purchase-bill">Purchase bill *</label>
              <span id="purchase-billFailed" class="required-text"></span>
              <input id="purchase-bill" name="purchase-bill" type="file" accept="image/*" class="required form-control">

              <div id="bill_thumbnail">
                <img id="thumbnail" class="thumbnail" src="">
              </div>
            </div>
          </div>

        </div>
        <div class="btn-submit" align="center">
          <button type="submit" class="submit" id="submit" name="submit">Submit</button>
        </div>
      </div>
    </form>
  </div>


<!-- EDIT SOWING REPORT FORM -->

<!-- IMAGE VIEWER -->

  <div class="view-image-wrapper">
    <div class="overlay-view-image-wrapper-close-btn">
      <span class="close-view-image-wrapper"><i class="fa fa-close" style="color: #FFFFFF;"></i></span>
    </div>
    <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 image-container" align="center">
      <h3 id="img-title"></h3>
      <div class="holder">
        <img id="imm" src=""><br/>
      </div>
    </div>
  </div>

  <script type="text/javascript" src="../js/jquery.js"></script>
  <script type="text/javascript" src="../js/bootstrap.js"></script>
  <script type="text/javascript" src="../js/jquery.isotope.min.js"></script>
  <script type="text/javascript" src="../js/wow.min.js"></script>
  <script type="text/javascript" src="../js/features.js"></script>
  <script type="text/javascript" src="../js/JQueryAJAX.js"></script>
  <script type="text/javascript" src="../js/sowing-report-validation.js"></script>
</body>
</html>