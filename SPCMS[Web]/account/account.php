<?php
require_once '../core/initInternal.php';

  if(!Session::exists('user')){
    Redirect::to('Login-form.php');
  }

  ## GETTING CUSTOMER'S/FARMER'S ID
  $output = DB::getInstance()->get('customer_account', array('user_id','=',Session::get('user') ));
  $customer_id = '';
  $user_id = '';
  if($output)
  {
    foreach ($output->results() as $output) {
      $customer_id = $output->customer_id;
      $user_id = $output->user_id;
    }
    Session::put("user_id", $user_id);
    Session::put("customer_id", $customer_id);
  }


  function Calendar($id)
  {
    $calendar = '';
    $month = '';
    $Checkmonth = '';
    $output = DB::getInstance()->get('appointment' , array('customer_id','=', $id));

    if($output)
    {
        foreach ($output->results() as $output) {
          $x = $output->date_of_appointment;
          $date = explode('-', $x);
          $y = $date[0];
          $m = $date[1];
          $d = $date[2];

        $monthName = date("F", mktime(0, 0, 0, $m, 10));
        $month = $monthName .' '. $y;

        if($month != $Checkmonth){
          $calendar .= '<li class="month"><i class="fa fa-calendar"></i> <span>'.$month.'</span></li>';
          $Checkmonth = $month;
        }

        $calendar .='
        <li class="calendar_list_content">
          <div class="activity-name">
            <h4>
              <span class="activity-name-name">
                <i class="glyphicon glyphicon-pushpin"></i> '.$output->title.'
              </span>
              <span class="calendar-date">
                  <i class="fa fa-calendar"></i> '.$d.' '.$monthName.'
              </span>
            </h4>
          </div>
          <div class="activity-details">
            '.$output->content.'
        </li>';
      }
    } else
    {
      $calendar = 'Nothing here Yet. Get Started';
    }
    return $calendar;
  }

  function Timeline($id)
  {
    $calendar = '';
    $month = '';
    $Checkmonth = '';
    $output = DB::getInstance()->get('timeline' , array('customer_id','=', $id));

    if($output)
    {
        foreach ($output->results() as $output) {
          $x = $output->date;
          $date = explode('-', $x);
          $y = $date[0];
          $m = $date[1];
          $d = $date[2];

        $monthName = date("F", mktime(0, 0, 0, $m, 10));
        $month = $monthName .' '. $y;

        if($month != $Checkmonth){
          $calendar .= '<li class="month"><i class="fa fa-calendar"></i> <span>'.$month.'</span></li>';
          $Checkmonth = $month;
        }

        $calendar .='
        <li class="calendar_list_content">
          <div class="activity-name">
            <h4>
              <span class="activity-name-name">
                <i class="glyphicon glyphicon-time"></i> Timeline
              </span>
              <span class="calendar-date">
                  <i class="fa fa-calendar"></i> '.$d.' '.$monthName.'
              </span>
            </h4>
          </div>
          <div class="activity-details">
            '.$output->content.'
        </li>';
      }
    } else
    {
      $calendar = 'Nothing here Yet. Get Started';
    }
    return $calendar;
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
      <a class="active-link" href="#">
        <i class="fa fa-history"></i>
        <li> &nbsp;&nbsp;&nbsp;Activities</li>
      </a>
      <a href="certification.php">
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
  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
  <h4>
    <span class="user-name">Hi <span><?php echo Session::get("Username") ?></span></span>
  </h4>
    <div class="tab_buttons">
      <button class="tab_cld col-xs-4">Calendar</button>
      <button class="tab_ucg col-xs-4">Timeline</button>
    </div>

    <div class="calendar_wrapper col-lg-12 col-md-12 col-sm-12 col-xs-12">
      <ul class="calendar_list">
        <?php echo Calendar($customer_id); ?>
        <div class="calendar_footer"><i class="fa fa-calendar"></i></div>
      </ul>
    </div>

    <div class="upcoming_wrapper col-lg-12 col-md-12 col-sm-12 col-xs-12">
      <ul class="calendar_list">
        <?php echo Timeline($customer_id); ?>
        <div class="calendar_footer"><i class="fa fa-calendar"></i></div>
      </ul>
    </div>

  </div>
</div>
  <script type="text/javascript" src="../js/jquery.js"></script>
  <script type="text/javascript" src="../js/bootstrap.js"></script>
  <script type="text/javascript" src="../js/jquery.isotope.min.js"></script>
  <script type="text/javascript" src="../js/wow.min.js"></script>
  <script type="text/javascript" src="../js/features.js"></script>
</body>
</html>
