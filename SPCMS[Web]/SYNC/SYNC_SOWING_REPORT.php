<?php
require_once '../core/initInternal.php';
$output = DB::getInstance()->query("SELECT * FROM sowing_report WHERE status ='Pending'");
if($output)
{
	print(json_encode($output->results()));
}
