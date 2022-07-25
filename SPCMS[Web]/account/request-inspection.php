<?php
require_once '../core/initInternal.php';

  if(!Session::exists('user')){
    Redirect::to('Login-form.php');
  }

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

  ## -- INSERTING INSPECTION REQUEST
  DB::getInstance()->insert('requested_inspection', array(
                'sowing_id' => Session::get('customer_id'),
                'payment_id' => $payment_id,
                'inspection_type' => Input::get('type'),
                'date' => date("Y-m-d")
              ));

  ## -- INSERTING INSPECTION REQUEST
  DB::getInstance()->insert('timeline', array(
                'customer_id' => Session::get('customer_id'),
                'content' => "You requested an inspection type of ".Input::get('type')."",
                'inspection_type' => Input::get('srcSeed'),
                'date' => Input::get('tagNo')
              ));
  Redirect::to('reqeust-inspection.php');
}


function Load_SowingReport()
{

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


function PreFlowering($id)
{
  return DB::getInstance()->get('pre_flowering_inspection',array('sowing_id','=', $id));
}

function Flowering($id)
{
  return DB::getInstance()->get('flowering_inspection',array('sowing_id','=', $id));
}

function PostFlowering($id)
{
  return DB::getInstance()->get('post_flowering_inspection',array('sowing_id','=', $id));
}

function Harvest($id)
{
  return DB::getInstance()->get('harvest_inspection',array('sowing_id','=', $id));
}

function SIO($id)
{
  $name = '';
  $x =  DB::getInstance()->get('user_account',array('user_id','=', $id));
  if($x->count() > 0)
  {
    foreach ($x->results() as $output)
    {
      $z = DB::getInstance()->get('user',array('employee_id','=', $output->employee_id));
      if ($z->count() > 0) {
        foreach ($z->results() as $opt) {
          $name = $opt->firstname .' '. $opt->last_name;
        }
      }
    }
  }
    return ($name != '') ? $name : "N/A";
}

function InsertHeader($sowing_id = '')
{
  $header = '';
  $num = PreFlowering($sowing_id)->count();
  $num = $num + Flowering($sowing_id)->count();
  $num = $num + PostFlowering($sowing_id)->count();
  $num = $num + Harvest($sowing_id)->count();
  $header .= '<div class="col-lg-4 col-md-4 inspection-container">
  <div>
  <h3>Field Inspection</h3>';
  $sowing = DB::getInstance()->get('sowing_report',array('sowing_id','=', $sowing_id));
  if($sowing->count() > 0)
  {
    foreach ($sowing->results() as $opt)
    {
      $cert_output = DB::getInstance()->get('certification_number',array('certification_id','=', $opt->certification_id));
      if($cert_output->count() > 0)
      {
        foreach ($cert_output as $_opt)
        {
          $header .='<h4>CERTIFICATION NO.: '.$_opt->certification_no.'</h4>';
        }
      }else
      {
            $header .='<h4>CERTIFICATION NO.: N/A</h4>';
      }
      $crop_output = DB::getInstance()->get('crop',array('crop_id','=', $opt->crop_id));
      foreach ($crop_output->results() as $crop) {

        $header .='<h4>'.$crop->crop_name.'</h4>';
      }


     $header .= '<h5>Inspections Conducted: <span class="badge">'.$num.'</span></h5>';
    }
    return $header;
  }
}

function LoadInspectionData($id)
{
  $report = '';
  $header = '';
  $sowing = DB::getInstance()->get('sowing_report',array('customer_id','=', $id));
  if($sowing->count() > 0)
  {
    foreach ($sowing->results() as $output)
    {
      $header = InsertHeader($output->sowing_id);
      $x = PreFlowering($output->sowing_id);
      if($x->count() > 0)
      {
        $report .= $header;
        foreach ($x->results() as $opt) {
          $report .='<table>
          <tr><td>INSPECTION TYPE:</td><td>Pre-Flowering</td></tr>
          <tr><td>SIO Allocated:</td><td>'.SIO($opt->user_id).'</td></tr>
          <tr><td>Date Conducted:</td><td>'.$opt->date.'</td></tr>
          <tr><td>View Inspection Report:</td><td><a href="#" class="open-inspections-report-pre-flowering '.$opt->inspection_Id.'">View Here</a></td></tr>
          </table>';
        }
      }

      $x = Flowering($output->sowing_id);
      if($x->count() > 0)
      {
        foreach ($x->results() as $opt) {
          $report .='<table>
          <tr><td>INSPECTION TYPE:</td><td>Flowering</td></tr>
          <tr><td>SIO Allocated:</td><td>'.SIO($opt->user_id).'</td></tr>
          <tr><td>Date Conducted:</td><td>'.$opt->date.'</td></tr>
          <tr><td>View Inspection Report:</td><td><a href="#" class="open-inspections-report-flowering '.$opt->inspection_id.'">View Here</a></td></tr>
          </table>';
        }
      }

      $x = PostFlowering($output->sowing_id);
      if($x->count() > 0)
      {
        foreach ($x->results() as $opt) {
          $report .='<table>
          <tr><td>INSPECTION TYPE:</td><td>Post Flowering</td></tr>
          <tr><td>SIO Allocated:</td><td>'.SIO($opt->user_id).'</td></tr>
          <tr><td>Date Conducted:</td><td>'.$opt->date.'</td></tr>
          <tr><td>View Inspection Report:</td><td><a href="#" class="open-inspections-report-post '.$opt->inspection_id.'">View Here</a></td></tr>
          </table>';
        }
      }

      $x = Harvest($output->sowing_id);
      if($x->count() > 0)
      {
        foreach ($x->results() as $opt) {
          $report .='<table>
          <tr><td>INSPECTION TYPE:</td><td>Harvest</td></tr>
          <tr><td>SIO Allocated:</td><td>'.SIO($opt->user_id).'</td></tr>
          <tr><td>Date Conducted:</td><td>'.$opt->date.'</td></tr>
          <tr><td>View Inspection Report:</td><td><a href="#" class="open-inspections-report-harvest '.$opt->inspection_id.'">View Here</a></td></tr>
          </table>';
        }
      }

    }
    $report .= '</div></div>';
  }

  return $report;
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

</div>
</header>

<nav class="_vertical_nav">
  <div>
    <h3>User Account</h3>
    <ul class="menu-links">
      <a href="account.php">
      	<i class="fa fa-history"></i>
      	<li> &nbsp;&nbsp;&nbsp;Activities</li>
      </a>
      <a href="certification.php">
      	<i class="fa fa-certificate"></i>
      	<li> &nbsp;&nbsp;&nbsp;Seed Certification</li>
      </a>
      <a class="active-link" href="#">
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
  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
	  <h4 style="margin-bottom: 40px;">
    <span class="user-name">Hi <span><?php echo Session::get("Username") ?></span></span>
	  </h4>
	  <div>
	  	<p>Tip: For a successful seed certification, at least two (2) or more Field inspections should be conducted on your seed field.</p>
      <p>To request for an Inspection <a href="#" id="open-inspections-request" class="open-inspections-request">Click Here</a></p>
	  </div>
      <?php echo LoadInspectionData(Session::get('customer_id'));  ?>
  </div>
</div>


<div class="inspections-request">
  <div class="close-inspections-request-btn">
    <span class="close-inspections-request">
      <i class="fa fa-close" style="color: #FFFFFF;"></i>
    </span>
      <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 report-content" style="background-color: rgb(223, 226, 214); margin-top: 40px;">
        <h3 align="center">REQUESTING INSPECTIONS</h3>
        <form role="form" style="margin-top: 40px;" method="POST" action=""  enctype="multipart/form-data" id="" class="" onsubmit="return ValidateRequest()">
          <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 form-content" style="background-color: rgb(223, 226, 214);">
            <div class="form-group">

            <label for="type">Inspection Type *</label>
            <span id="typeFailed" class="required-text"></span>
            <select name="type" class="form-control" id="type">
              <option value="" disabled selected hidden>Select Inspection Tyepe</option>
              <option value="Pre Flowering">Pre Flowering</option>
              <option value="Flowering">Flowering</option>
              <option value="Post Flowering">Post Flowering</option>
              <option value="Harvest">Harvest</option>  
            </select>

            <label for="sowing">Sowing Report *</label>
            <span id="sowingFailed" class="required-text"></span>
            <select name="sowing" class="form-control" id="sowing">
              <option value="" disabled selected hidden>Select a Sowing Report</option>
              <option value="">Sowing Report</option>
            </select>

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

            <div class="btn-submit" align="center">
              <button type="submit" class="submit" id="submit" name="submit">Submit</button>
            </div>
            </div>
          </div>
        </form>
      </div>
  </div>
</div>



<div class="inspections-report-container-pre-flowering">
  <div class="inspections-report-container-close-btn">
    <span class="close-inspection-report">
      <i class="fa fa-close" style="color: #FFFFFF;"></i>
    </span>
    <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 report-content" style="background-color: rgb(223, 226, 214); margin-top: 40px;">
        <h3 align="center">PRE FLOWERING INSPECTION REPORT</h3>

        <table>
         <tr>
           <th>CERTIFICATION NO.:</th>
           <th id="pre-certificate">############</th>
         </tr>
          <tr>
           <td>SIO Allocated:</td>
           <td id="pre-sio">########### ########</td>
          </tr>
          <tr>
            <td>Date Conducted:</td>
            <td id="pre-date">##-##-####</td>
          </tr>
          <tr>
           <td>Inspection Type:</td>
           <td>Pre Flowering Inspection</td>
          </tr>
        </table>

        <h4 align="">INSPECTION DETAILS</h4>

        <table>
          <tr>
           <td>Crop:</td>
           <td id="pre-crop">########### ########</td>
          </tr>
          <tr>
            <td>Variety:</td>
            <td id="pre-variety">###########</td>
          </tr>
          <tr>
           <td>Isolation Distance:</td>
           <td id="pre-isolation">############# ########</td>
          </tr>
          <tr>
           <td>Seeds Source:</td>
           <td  id="pre-source">############# ########</td>
          </tr>
          <tr>
           <td>Acreage:</td>
           <td id="pre-acreage">############# ########</td>
          </tr>
          <tr>
           <td>Planting Uniformity:</td>
           <td id="pre-uniformity">############# ########</td>
          </tr>
          <tr>
           <td>Proper Rouging:</td>
           <td id="pre-rouging">############# ########</td>
          </tr>
          <tr>
           <td>Identifying Off-Types:</td>
           <td id="pre-offtype">############# ########</td>
          </tr>
          <tr>
           <td>Off-Type Removal:</td>
           <td id="pre-removal">####</td>
          </tr>
        </table>
        <h4 align="">INSPECTOR'S REMARKS</h4>
        <p id="pre-remarks">
        </p>
      </div>
  </div>
</div>


<div class="inspections-report-container-flowering">
  <div class="inspections-report-container-close-btn">
    <span class="close-inspection-report">
      <i class="fa fa-close" style="color: #FFFFFF;"></i>
    </span>
    <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 report-content" style="background-color: rgb(223, 226, 214); margin-top: 40px;">
        <h3 align="center">FLOWERING INSPECTION REPORT</h3>

        <table>
         <tr>
           <th>CERTIFICATION NO.:</th>
           <th id="flo-certificate">############</th>
         </tr>
          <tr>
           <td>SIO Allocated:</td>
           <td id="flo-sio">########### ########</td>
          </tr>
          <tr>
            <td>Date Conducted:</td>
            <td id="flo-date">##-##-####</td>
          </tr>
          <tr>
           <td>Inspection Type:</td>
           <td>Pre Flowering Inspection</td>
          </tr>
        </table>

        <h4 align="">INSPECTION DETAILS</h4>

        <table>
          <tr>
           <td>Crop:</td>
           <td id="flo-crop">########### ########</td>
          </tr>
          <tr>
            <td>Variety:</td>
            <td id="flo-variety">###########</td>
          </tr>
          <tr>
           <td>Isolation Maintained:</td>
           <td id="flo-isolation">############# ########</td>
          </tr>
          <tr>
           <td>Off-Type Removal:</td>
           <td  id="flo-offtype">############# ########</td>
          </tr>
        </table>
        <h4 align="">INSPECTOR'S REMARKS</h4>
        <p id="flo-remarks">
        </p>
      </div>
  </div>
</div>


<div class="inspections-report-container-post-flowering">
  <div class="inspections-report-container-close-btn">
    <span class="close-inspection-report">
      <i class="fa fa-close" style="color: #FFFFFF;"></i>
    </span>
    <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 report-content" style="background-color: rgb(223, 226, 214); margin-top: 40px;">
        <h3 align="center">POST FLOWERING INSPECTION REPORT</h3>
        <table>
         <tr>
           <th>CERTIFICATION NO.:</th>
           <th id="post-certificate">############</th>
         </tr>
          <tr>
           <td>SIO Allocated:</td>
           <td id="post-sio">########### ########</td>
          </tr>
          <tr>
            <td>Date Conducted:</td>
            <td id="post-date">##-##-####</td>
          </tr>
          <tr>
           <td>Inspection Type:</td>
           <td>Post Flowering Inspection</td>
          </tr>
        </table>

        <h4 align="">INSPECTION DETAILS</h4>

        <table>
          <tr>
           <td>Crop:</td>
           <td id="post-crop">########### ########</td>
          </tr>
          <tr>
            <td>Variety:</td>
            <td id="post-variety">###########</td>
          </tr>
          <tr>
           <td>Issues Taken care off:</td>
           <td id="post-issues-taken-care">  ############# ########</td>
          </tr>
          <tr>
        </table>
        <h4 align="">INSPECTOR'S REMARKS</h4>
        <p id="post-remarks">
        </p>
      </div>
  </div>
</div>


<div class="inspections-report-container-harvest">
  <div class="inspections-report-container-close-btn">
    <span class="close-inspection-report">
      <i class="fa fa-close" style="color: #FFFFFF;"></i>
    </span>
    <div class="col-lg-8 col-md-8 col-sm-10 col-xs-10 col-lg-offset-2 col-md-offset-2 col-sm-offset-1 col-xs-offset-1 report-content" style="background-color: rgb(223, 226, 214); margin-top: 40px;">
        <h3 align="center">HARVEST INSPECTION REPORT</h3>

        <table>
         <tr>
           <th>CERTIFICATION NO.:</th>
           <th id="harvest-certificate">############</th>
         </tr>
          <tr>
           <td>SIO Allocated:</td>
           <td id="harvest-sio">########### ########</td>
          </tr>
          <tr>
            <td>Date Conducted:</td>
            <td id="harvest-date">##-##-####</td>
          </tr>
          <tr>
           <td>Inspection Type:</td>
           <td>Post Flowering Inspection</td>
          </tr>
        </table>

        <h4 align="">INSPECTION DETAILS</h4>

        <table>
          <tr>
           <td>Crop:</td>
           <td id="harvest-crop">########### ########</td>
          </tr>
          <tr>
            <td>Variety:</td>
            <td id="harvest-variety">###########</td>
          </tr>
          <tr>
           <td>Maturity:</td>
           <td id="harvest-maturity">############# ########</td>
          </tr>
        </table>
        <h4 align="">INSPECTOR'S REMARKS</h4>
        <p id="harvest-remarks">
        </p>
      </div>
  </div>
</div>


<style type="text/css">

.inspections-report-container-pre-flowering, .inspections-report-container-flowering,
.inspections-report-container-post-flowering, .inspections-report-container-harvest,
.inspections-request 
  {
    width: 100%;
    height: 100vh;
    position: fixed;
    left: 0;
    top: 0;
    z-index: 999;
    background-color: rgba(0,0,0,.8);
    display: none;
  }

	.inspection-container
	{
		background-color: rgb(234, 234, 234);
		padding: 10px;
	}
  .inspection-container table
  {
    margin-bottom: 20px;
  }
	.inspection-container table th:nth-child(even),
	.inspection-container table td:nth-child(even)
	{
		padding-left: 8px;
	}

</style>

  <script type="text/javascript" src="../js/jquery.js"></script>
  <script type="text/javascript" src="../js/bootstrap.js"></script>
  <script type="text/javascript" src="../js/jquery.isotope.min.js"></script>
  <script type="text/javascript" src="../js/wow.min.js"></script>
  <script type="text/javascript" src="../js/features.js"></script>
  <script type="text/javascript" src="../js/JQueryAJAX.js"></script>
  <script type="text/javascript" src="../js/RIValidation.js"></script>
</body>
</html>
