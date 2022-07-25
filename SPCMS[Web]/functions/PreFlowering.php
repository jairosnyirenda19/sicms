<?php
require_once '../core/initInternal.php';

//$_POST['id'] = 4;
if (isset($_POST['id']))
{
  echo json_encode(PreFloweringData($_POST['id']));
}


function PreFloweringData($_id)
{
  $output = DB::getInstance()->get('pre_flowering_inspection', array('inspection_Id' ,'=' , $_id));
  $results = array();

  if($output)
  {
      foreach ($output->results() as $output)
      {
        $results["certification"] = Certification($output->sowing_id);
        $results["SIO"] = SIO($output->user_id);
        $results["crop"] = Crop($output->sowing_id);
        $results["variety"] = Variety($output->sowing_id);
        $results["date"] = $output->date;
        $results["isolation_distance"] = $output->isolation_distance;
        $results["source"] = $output->source;
        $results["acreage"] = $output->acreage;
        $results["uniformity"] = $output->uniformity;
        $results["rouging"] = $output->rouging;
        $results["off_type"] = $output->off_type;
        $results["removal"] = $output->removal;
        $results["remarks"] = $output->remarks;
     }
  }
  return $results;
}


function Certification($id)
{
  $certification = 'N/A';
  $sowing = DB::getInstance()->get('sowing_report',array('sowing_id','=', $id));
  if($sowing->count() > 0)
  {
    foreach ($sowing->results() as $opt)
    {
      $cert_output = DB::getInstance()->get('certification_number',array('certification_id','=', $opt->certification_id));
      if($cert_output->count() > 0)
      {
        foreach ($cert_output as $_opt)
        {
          $certification = $_opt->certification_no;
        }
      }
    }
    return $certification;
  }
}

function Crop($id)
{
  $x = '';
  $sowing = DB::getInstance()->get('sowing_report',array('sowing_id','=', $id));
  if($sowing->count() > 0)
  {
    foreach ($sowing->results() as $opt)
    {
      $output = DB::getInstance()->get('crop',array('crop_id','=', $opt->crop_id));
      if($output->count() > 0)
      {
        foreach ($output->results() as $output)
        {
          $x = $output->crop_name;
        }
      }
    }
  }
  return $x;
}

function Variety($id)
{
  $variety = '';
  $sowing = DB::getInstance()->get('sowing_report',array('sowing_id','=', $id));
  if($sowing->count() > 0)
  {
    foreach ($sowing->results() as $opt)
    {
      $output = DB::getInstance()->get('variety',array('variety_id','=', $opt->variety_id));
      if($output->count() > 0)
      {
        foreach ($output->results() as $output)
        {
          $variety = $output->variety_name;
        }
      }
    }
  }
  return $variety;
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
