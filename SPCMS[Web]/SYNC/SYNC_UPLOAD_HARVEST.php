<?php
require_once '../core/initInternal.php';

//$JSON = "{\"harvest_id\":0,\"sowing_id\":2,\"maturity\":\"Verified\",\"remarks\":\"yewsss\",\"date\":\"2020-03-24T00:25:24.351544\",\"inspector\":\"Jay_2607\"}";
$JSON = file_get_contents('php://input');
$data = json_decode($JSON);

if($data != null)
{
    $inspector_id = '';
    $output = DB::getInstance()->get('user_account' , array('username','=', $data->inspector));
    if($output)
    {
      foreach ($output->results() as $output) {
        $inspector_id = $output->user_id;
      }
    }

    $output = DB::getInstance()->get('harvest_inspection' , array('sowing_id','=', $data->sowing_id));
    if($output->count() == 0)
    {
        DB::getInstance()->insert('harvest_inspection', array(
                      'user_id' => $inspector_id,
                      'sowing_id' => $data->sowing_id,
                      'maturity' => $data->maturity,
                      'remarks' => $data->remarks,
                      'date' => $data->date
                    ));
    }else
    {
      DB::getInstance()->update('harvest_inspection', 'sowing_id', $data->sowing_id, array(
                    'user_id' => $inspector_id,
                    'maturity' => $data->maturity,
                    'remarks' => $data->remarks,
                    'date' => $data->date
                  ));
    }
}
