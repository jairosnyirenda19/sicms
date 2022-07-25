<?php
require_once '../core/initInternal.php';

$JSON = file_get_contents('php://input');
$data = json_decode($JSON);

#$JSON = "{\"preflowering_id\":0,\"sowing_id\":2,\"isolation_distance\":25.0,\"source\":\"Verified\",\"acreage\":\"Verified\",\"uniformity\":\"Verified\",\"rouging\":\"Verified\",\"off_types\":\"Verified\",\"removal\":\"Verified\",\"remarks\":\"glory\",\"date\":\"2020-03-24T00:26:43.124781\",\"inspector\":\"Jay_2607\"}";
#$data = json_decode($JSON);

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

    $output = DB::getInstance()->get('pre_flowering_inspection' , array('sowing_id','=', $data->sowing_id));

    if($output->count() == 0)
    {
        DB::getInstance()->insert('pre_flowering_inspection', array(
                      'user_id' => $inspector_id,
                      'sowing_id' => $data->sowing_id,
                      'isolation_distance' => $data->isolation_distance,
                      'source' => $data->source,
                      'acreage' => $data->acreage,
                      'uniformity' => $data->uniformity,
                      'rouging' => $data->rouging,
                      'off_type' => $data->off_types,
                      'removal' => $data->removal,
                      'remarks' => $data->remarks,
                      'date' => $data->date
                    ));
    }else
    {
      DB::getInstance()->update('pre_flowering_inspection', 'sowing_id', $data->sowing_id, array(
                    'user_id' => $inspector_id,
                    'isolation_distance' => $data->isolation_distance,
                    'source' => $data->source,
                    'acreage' => $data->acreage,
                    'uniformity' => $data->uniformity,
                    'rouging' => $data->rouging,
                    'off_type' => $data->off_types,
                    'removal' => $data->removal,
                    'remarks' => $data->remarks,
                    'date' => $data->date
                  ));
    }
}
