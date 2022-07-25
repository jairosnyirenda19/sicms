$(document).ready(function() {
	$('#crop').change(function(){
		var crop_id = $(this).val();
		$.ajax({
			url:"../functions/FetchVariety.php",
			method: "POST",
			data:{CropId:crop_id},
			dataType:"text",
			success:function(data)
			{
				$('#variety').html(data);
			}
		});
	});

	$('#username').keyup(function(){
		var username = $(this).val();
		$.ajax({
			url:"../functions/CheckUsername.php",
			method: "POST",
			data:{username:username},
			dataType:"text",
			success:function(data)
			{
				$('#usernameFailed').html(data);
			}
		});
	});

	$('.open-view-image-container').click(function(){
		var dir = $(this).attr('id');
		var spl = dir.split('.');
		$.ajax({
			url:"../functions/GetImage.php",
			method: "POST",
			data:{dir:dir},
			dataType:"text",
			success:function(data)
			{
				$('#img-title').text(spl[(spl.length - 1)]);
				$("#imm").attr("src", data);
			}
		});
	});

	$('.open-edit-sowing-report').click(function(){
		$(".overlay-wrapper-sowing-report").fadeIn();
		var atr = $(this).attr('class');
		var spl = atr.split(' ');
		var sowing_id = spl[1];
		$.ajax({
			url:"../functions/FetchEditResult.php",
			method: "POST",
			data:{sowing_id:sowing_id},
			dataType: "json",
			success:function(data)
			{
				$('.formTitle').text('EDIT SOWING REPORT');
				$('.submit').attr('name', 'submit-edit');
				$('.submit').text('Edit');
				$('#primarykey').val(sowing_id);
				$('#payment_id').val(data.payment_id);


				$("#bank_deposit_slip_thumbnail").hide();
				$("#tag_thumbnail").hide();
				$("#bill_thumbnail").hide();

				$('#crop').html(data.crop);
				$('#variety').html(data.variety);
				$('#seedClass').html(data.class);
				$('#srcSeed').val(data.seed_source);
				$('#tagNo').val(data.tag_number);
				$('#billNo').val(data.purchase_bill_no);
				$('#date-of-purchase').val(data.date_of_purchase);
				$('#quantity').val(data.quantity_per_acrea);
				$('#acreage').val(data.acreage);
				$('#date-of-sowing').val(data.date_of_sowing);

				if(data.method_id == 1)
				{
					$('#bank-service').prop("checked",true);
					$('#bank-service-select').html(data.bank_name);
					$("#bank_deposit_slip_thumbnail").show();
					$("#bank_deposit_slip_thumbnail").html('<img id="thumbnail" class="thumbnail" src="'+data.bank_thumbnail+'">');

				}else
				{
					$('#mobile-service').prop("checked",true);
					$('.mobile-service').show();
					$('.mode-bank').hide();
					$('#mobile-service-select').html(data.service_name);
					$('#referenceNo').val(data.transaction_id);

				}

				$("#tag_thumbnail").show();
				$("#bill_thumbnail").show();

				$("#tag_thumbnail").html('<img id="thumbnail" class="thumbnail" src="'+data.tag_thumbnail+'">');
				$("#bill_thumbnail").html('<img id="thumbnail" class="thumbnail" src="'+data.bill_thumbnail+'">');
			}
		});
	});

	$('.open-inspections-report-pre-flowering').click(function()
	{
		var atr = $(this).attr('class');
		var spl = atr.split(' ');
		var id = spl[1];
		$.ajax({
			url:"../functions/PreFlowering.php",
			method: "POST",
			data:{id:id},
			dataType: "json",
			success:function(data)
			{
				$('#pre-certificate').html(data.certification);
				$('#pre-sio').html(data.SIO);
				$('#pre-date').html(data.date);
				$('#pre-crop').html(data.crop);
				$('#pre-variety').html(data.variety);
				$('#pre-isolation').html(data.isolation_distance);
				$('#pre-source').html(data.source);
				$('#pre-acreage').html(data.acreage);
				$('#pre-uniformity').html(data.uniformity);
				$('#pre-rouging').html(data.rouging);
				$('#pre-offtype').html(data.off_type);
				$('#pre-removal').html(data.removal);
				$('#pre-remarks').html(data.remarks);
			}
		});
	});

	$('.open-inspections-report-flowering').click(function()
	{
		var atr = $(this).attr('class');
		var spl = atr.split(' ');
		var id = spl[1];
		$.ajax({
			url:"../functions/Flowering.php",
			method: "POST",
			data:{id:id},
			dataType: "json",
			success:function(data)
			{
				$('#flo-certificate').html(data.certification);
				$('#flo-sio').html(data.SIO);
				$('#flo-date').html(data.date);
				$('#flo-crop').html(data.crop);
				$('#flo-variety').html(data.variety);
				$('#flo-isolation').html(data.isolation_maintain);
				$('#flo-offtype').html(data.off_type_removal);
				$('#flo-remarks').html(data.remarks);
			}
		});
	});

	$('.open-inspections-report-post').click(function(){
		var atr = $(this).attr('class');
		var spl = atr.split(' ');
		var id = spl[1];
		$.ajax({
			url:"../functions/PostFlowering.php",
			method: "POST",
			data:{id:id},
			dataType: "json",
			success:function(data)
			{
				$('#post-certificate').html(data.certification);
				$('#post-sio').html(data.SIO);
				$('#post-date').html(data.date);
				$('#post-crop').html(data.crop);
				$('#post-variety').html(data.variety);
				$('#post-issues-taken-care').html(data.issues_taken_care);
				$('#post-remarks').html(data.remarks);
			}
		});
	});

	$('.open-inspections-report-harvest').click(function(){
		var atr = $(this).attr('class');
		var spl = atr.split(' ');
		var id = spl[1];
		$.ajax({
			url:"../functions/Harvest.php",
			method: "POST",
			data:{id:id},
			dataType: "json",
			success:function(data)
			{
				$('#harvest-certificate').html(data.certification);
				$('#harvest-sio').html(data.SIO);
				$('#harvest-date').html(data.date);
				$('#harvest-crop').html(data.crop);
				$('#harvest-variety').html(data.variety);
				$('#harvest-maturity').html(data.maturity);
				$('#harvest-remarks').html(data.remarks);
			}
		});
	});

});
