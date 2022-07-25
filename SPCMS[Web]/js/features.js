jQuery(function($) {

	//Initiat WOW JS
	new WOW().init();
});

$(document).ready(function() {

	$(window).scroll(function() {
		if($(this).scrollTop() > 100)
			{
				$("#topBtn").fadeIn();
			} else
			{
				$("#topBtn").fadeOut();
			}
	});

	$(".mobile-service").hide();

	$("#bank-service").change(function(){
		$(".mobile-service").hide();
		$(".mode-bank").show();
	});

	$("#mobile-service").change(function(){
		$(".mobile-service").show();
		$(".mode-bank").hide();
	});

	$("#topBtn").click(function() {
		$('html, body').animate({scrollTop :0},800);
	});


	$('.menu-icon').click(function() {
	$('.main-menu').toggleClass('visible');
	});

	$('.menu-icon-account').click(function() {
	$('._vertical_nav').toggleClass('open');
	});

	$('.open-sowing-report').click(function() {
		$(".overlay-wrapper-sowing-report").fadeIn();
		$("#bank_deposit_slip_thumbnail").hide();
		$("#tag_thumbnail").hide();
		$("#bill_thumbnail").hide();
		$('.formTitle').text('SOWING REPORT');
		$('.submit').attr('name', 'submit');
		$('.submit').text('Submit');

		$('#crop').val("Select Crop");
		$('#variety').val("Select Variety");
		$('#seedClass').val("Select Class");
		$('#srcSeed').val("");
		$('#tagNo').val("");
		$('#billNo').val("");
		$('#date-of-purchase').val("");
		$('#quantity').val("");
		$('#acreage').val("");
		$('#date-of-sowing').val("");
		$('#bank-service').prop("checked",true);
		$('#bank-service-select').val("Select Service");
		$('#mobile-service').prop("checked",false);
		$('#mobile-service-select').val("Select Service");
		$('#referenceNo').val("");
	});


	$('.open-inspections-request').click(function() {
	$(".inspections-request").fadeIn();
	$("#bank_deposit_slip_thumbnail").hide();	
	});

	$('.open-view-image-container').click(function() {
	$(".view-image-wrapper").fadeIn();
	});

	$('.open-inspections-report-pre-flowering').click(function() {
	$(".inspections-report-container-pre-flowering").fadeIn();
	});

	$('.open-inspections-report-flowering').click(function() {
	$(".inspections-report-container-flowering").fadeIn();
	});

	$('.open-inspections-report-post').click(function() {
	$(".inspections-report-container-post-flowering").fadeIn();
	});

	$('.open-inspections-report-harvest').click(function() {
	$('.inspections-report-container-harvest').fadeIn();
	});

	$('#btn').click(function(){
	$(".overlay-wrapper-sowing-report").fadeIn();
	});

	$('.close-sowing-report').click(function() {
	$(".overlay-wrapper-sowing-report").fadeOut();
	});

	$('.close-view-image-wrapper').click(function() {
	$(".view-image-wrapper").fadeOut();
	});


	$('.close-inspection-report').click(function() {
	$(".inspections-report-container-pre-flowering").fadeOut();
	$(".inspections-report-container-flowering").fadeOut();
	$(".inspections-report-container-post-flowering").fadeOut();
	$(".inspections-report-container-harvest").fadeOut();	
	});

	$('.close-inspections-request').click(function() {
		$(".inspections-request").fadeOut();
	});
});

$(document).ready(function() {

	$(".tab_cld").css("background","rgb(20, 28, 31)");
	$(".tab_cld").css("color","rgb(255,255,255)");

	$(".calendar_wrapper").show();
	$(".upcoming_wrapper").hide();
	$(".timeline_wrapper").hide();


	$(".tab_cld").click(function()
	{
		$(".tab_cld").css("background","rgb(20, 28, 31)");
		$(".tab_cld").css("color","rgb(255,255,255)");

		$(".tab_ucg").css("background","rgb(241, 243, 237)");
		$(".tab_ucg").css("color","rgb(41,41,41)");

		$(".tab_tml").css("background","rgb(241, 243, 237)");
		$(".tab_tml").css("color","rgb(41,41,41)");

		$(".calendar_wrapper").show();
		$(".upcoming_wrapper").hide();
		$(".timeline_wrapper").hide();

	});

	$(".tab_ucg").click(function()
	{
		$(".tab_cld").css("background","rgb(241, 243, 237)");
		$(".tab_cld").css("color","rgb(41,41,41)");

		$(".tab_ucg").css("background","rgb(20, 28, 31)");
		$(".tab_ucg").css("color","rgb(255,255,255)");

		$(".tab_tml").css("background","rgb(241, 243, 237)");
		$(".tab_tml").css("color","rgb(41,41,41)");

		$(".calendar_wrapper").hide();
		$(".upcoming_wrapper").show();
		$(".timeline_wrapper").hide();
	});

	$(".tab_tml").click(function()
	{
		$(".tab_cld").css("background","rgb(241, 243, 237)");
		$(".tab_cld").css("color","rgb(41,41,41)");

		$(".tab_ucg").css("background","rgb(241, 243, 237)");
		$(".tab_ucg").css("color","rgb(41,41,41)");

		$(".tab_tml").css("background","rgb(20, 28, 31)");
		$(".tab_tml").css("color","rgb(255,255,255)");

		$(".calendar_wrapper").hide();
		$(".upcoming_wrapper").hide();
		$(".timeline_wrapper").show();
	});

});
