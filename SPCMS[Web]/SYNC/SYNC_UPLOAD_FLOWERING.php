<?php
require_once '../core/initInternal.php';

$JSON = file_get_contents('php://input');
$data = json_decode($JSON);
//$JSON = "{\"flowering_id\":0,\"sowing_id\":2,\"isolation_maintain\":\"Verified\",\"off_type_removal\":\"Verified\",\"remarks\":\"glory 2\",\"date\":\"2020-03-24T00:25:01.161203\",\"inspector\":\"Jay_2607\"}";
//var_dump($data);

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

    $output = DB::getInstance()->get('flowering_inspection' , array('sowing_id','=', $data->sowing_id));

    if($output->count() == 0)
    {
        DB::getInstance()->insert('flowering_inspection', array(
                      'user_id' => $inspector_id,
                      'sowing_id' => $data->sowing_id,
                      'isolation_maintain' => $data->isolation_maintain,
                      'off_type_removal' => $data->off_type_removal,
                      'remarks' => $data->remarks,
                      'date' => $data->date
                    ));
    }else
    {
      DB::getInstance()->update('flowering_inspection', 'sowing_id', $data->sowing_id, array(
                    'user_id' => $inspector_id,
                    'isolation_maintain' => $data->isolation_maintain,
                    'off_type_removal' => $data->off_type_removal,
                    'remarks' => $data->remarks,
                    'date' => $data->date
                  ));
    }
}
