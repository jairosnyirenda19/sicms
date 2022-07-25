<?php
require_once '../core/initInternal.php';

$JSON = file_get_contents('php://input');
//$JSON = "{\"post_flowering_id\":0,\"sowing_id\":2,\"issues_taken_care\":\"Verified\",\"remarks\":\"glory\",\"date\":\"2020-03-24T00:25:13.262183\",\"inspector\":\"Jay_2607\"}";
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

    $output = DB::getInstance()->get('post_flowering_inspection' , array('sowing_id','=', $data->sowing_id));
    if($output ->count() == 0)
    {
        DB::getInstance()->insert('post_flowering_inspection', array(
                      'user_id' => $inspector_id,
                      'sowing_id' => $data->sowing_id,
                      'issues_taken_care' => $data->issues_taken_care,
                      'remarks' => $data->remarks,
                      'date' => $data->date
                    ));
    }else
    {
      DB::getInstance()->update('post_flowering_inspection', 'sowing_id', $data->sowing_id, array(
                    'user_id' => $inspector_id,
                    'issues_taken_care' => $data->issues_taken_care,
                    'remarks' => $data->remarks,
                    'date' => $data->date
                  ));
    }
}
