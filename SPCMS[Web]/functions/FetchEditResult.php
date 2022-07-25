<?php
require_once '../core/initInternal.php';

//$_POST['sowing_id'] = 4;
if (isset($_POST['sowing_id']))
{
  echo json_encode(Get_Sowing_report($_POST['sowing_id']));
}


function Get_Sowing_report($_id)
{
  $output = DB::getInstance()->get('sowing_report', array('sowing_id' ,'=' , $_id));
  $results = array();

  if($output)
  {
    foreach ($output->results() as $output)
    {
      $results["payment_id"] = $output->payment_id;
      $crop_output = DB::getInstance()->get('crop',array('crop_id','=', $output->crop_id));
      if($crop_output)
      {
        foreach ($crop_output->results() as $opt)
        {
          $results["crop"] = '<option value="'.$opt->crop_id.'">'.$opt->crop_name.'</option>';
          $results["crop"] .= Load_Crop($opt->crop_name);
        }
      }

      $cert_output = DB::getInstance()->get('certification_number',array('certification_id','=', $output->certification_id));
      if($cert_output->count() > 0)
      {
        foreach ($cert_output as $opt) {
          $results['certification_no'] = $opt->certification_no;
        }
      }

      $variety_output = DB::getInstance()->get('variety', array('variety_id', '=', $output->variety_id));
      if($variety_output)
      {
        foreach ($variety_output->results() as $a) {
          $results['variety'] = '<option value="'.$a->variety_id.'">'.$a->variety_name.'</option>';
          $results['variety'] .=  Load_Variety($a->crop_id, $a->variety_name);
        }
      }

      $results['acreage'] = $output->acreage;

      $class_output = DB::getInstance()->get('class',array('class_id','=', $output->class_id));
      if($class_output)
      {
        foreach ($class_output->results() as $opt)
        {
          $results['class'] = '<option value="'.$opt->class_id.'">'.$opt->class_name.' - '.$opt->genetic_purity.' Genetic Purity</option>';
          $results['class'] .= Load_Class();
        }
      }

      $results['quantity_per_acrea'] = $output->quantity_per_acrea;
      $results['date_of_sowing'] = $output->date_of_sowing;
      $results['seed_source'] =  $output->seed_source;
      $results['tag_number'] = $output->tag_number;
      $results['purchase_bill_no'] = $output->purchase_bill_no;
      $results['date_of_purchase'] = $output->date_of_purchase;
      $results['tag_thumbnail'] = $output->tagSrc;
      $results['bill_thumbnail'] = $output->purchaseBill;

      $payment_ouptut = DB::getInstance()->get('payment_details',array('payment_id','=', $output->payment_id));
       if($payment_ouptut)
       {
          foreach ($payment_ouptut->results() as $opt) {
            $results['method_id'] = $opt->method_id;
            if($opt->method_id == 1)
            {
              $bank_output = DB::getInstance()->get('bank_service',array('bank_id','=', $opt->bank_id));
              foreach ($bank_output->results() as $bank) {
                $results['bank_name'] = '<option value="'.$bank->bank_id.'"> '.$bank->bank_name.': '.$bank->account_number.' </option>';
                $results['bank_name'] .= Load_BankPayment($bank->bank_name);
                $results['bank_thumbnail'] = $opt->bank_deposit_slip;
              }

            }else
            {
              $mobile_service = DB::getInstance()->get('mobile_service',array('service_id','=', $opt->service_id));
                foreach ($mobile_service->results() as $mobile)
                {
                  $results['service_name'] = '<option value="'.$mobile->service_id.'">'.$mobile->service_name.'</option>';
                  $results['service_name'] .= Load_MobilePayment($mobile->service_name);
                  $results['transaction_id'] = $opt->transaction_id;
                }
            }
          }
       }
     }
   }

  return $results;
}

function Load_Crop($name)
{
  $output = DB::getInstance()->query('SELECT * FROM crop WHERE NOT (crop_name = "'.$name.'")');
  $crop = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $crop .= '<option value="'.$output->crop_id.'">'.$output->crop_name.'</option>';
    }
  }
  return $crop;
}

function Load_Variety($id, $name)
{
  $output = DB::getInstance()->query('SELECT * FROM variety WHERE crop_id = 1 AND NOT (variety_name = "Sweet Corn - Zea mays saccharata")');
  $variety = '';

  if($output->count() > 0)
  {

    foreach ($output->results() as $output) {
      $variety .= '<option value="'.$output->variety_id.'">'.$output->variety_name.'</option>';
    }
  }

  return $variety;
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


function Load_MobilePayment($name)
{
  $output = DB::getInstance()->query('SELECT * FROM mobile_service WHERE NOT (service_name = "'.$name.'")');
  $service = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $service .= '<option value="'.$output->service_id.'">'.$output->service_name.'</option>';
    }
  }
  return $service;
}

function Load_BankPayment($name)
{
  $output = DB::getInstance()->query('SELECT * FROM bank_service WHERE NOT (bank_name = "'.$name.'")');
  $service = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $service .= '<option value="'.$output->bank_id.'"> '.$output->bank_name.': '.$output->account_number.' </option>';
    }
  }
  return $service;
}
