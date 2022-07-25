<?php
require_once '../core/initInternal.php';

$output = DB::getInstance()->get('variety' , array('crop_id','=', $_POST["CropId"]));
$variety = '<option value="" disabled selected hidden>Select Variety</option>';

if($output)
{
	foreach ($output->results() as $output) {
		$variety .= '<option value="'.$output->variety_id.'">'.$output->variety_name.'</option>';
	}
}

echo $variety;
