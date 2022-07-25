var type = document.getElementById("type");
var sowing = document.getElementById("sowing");
var mobileService = document.getElementById("mobile-service-select");
var referenceNo = document.getElementById("referenceNo");
var bankService = document.getElementById("bank-service-select");
var depositSlip = document.getElementById("deposit-slip");
var buttonName = document.getElementById("submit");
var requiredText = document.getElementsByClassName("required-text");
var editmode= false;


function ValidatePayment()
{
	if(document.getElementById("mobile-service").checked)
	{
		if(mobileService.value == "" || mobileService.value == null)
		{
			requiredText[2].innerHTML = "Please Select a mobile service"
			mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");			
			return false;
		}
		if(referenceNo.value == "" || referenceNo.value == null)
		{
			requiredText[3].innerHTML = "Please provide reference/transtaction number"
			referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}	
	}
	else if(document.getElementById("bank-service").checked)
	{
		if(bankService.value == "" || bankService.value == null)
		{
			requiredText[4].innerHTML = "Please Select a bank service"
			bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}

		if(depositSlip.value == "" || depositSlip.value == null)
		{
			requiredText[5].innerHTML = "Please provide the deposit slip"
			depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}else if(!validateImage('deposit-slip'))
		{
			requiredText[5].innerHTML = "Please select a valid image file";
			depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}
	}
	return true;
}

function ValidateRequest()
{
	if((type.value == "" || type.value == null) && (sowing.value == "" || sowing.value ==  null) && (mobileService.value == "" || mobileService.value == null) && (referenceNo.value == "" || referenceNo.value == null) &&		
		(bankService.value == "" || bankService == null) && (depositSlip.value == "" || depositSlip.value == null))
	{
		for (var i = 0; i < requiredText.length; i++) 
		{
			requiredText[i].innerHTML = "This field is required."; 	
		}
		type.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		sowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		return false;
	}
	else
	{
		if(type.value == "" || type.value == null)
		{
			requiredText[0].innerHTML = "Please Select an Inspection Type";
			crop.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}
		if(sowing.value == "" || sowing.value ==  null)
		{
			requiredText[1].innerHTML = "Please Select a Sowing Report";
			variety.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}

				
		if(!ValidatePayment())
		{
			return false;
		}		
	}
	return true;
}

function validateImage(id)
{
	var formData = new FormData();
	var file = document.getElementById(id).files[0];
	formData.append("Filedata",file);
	var t = file.type.split('/').pop().toLowerCase();

	if(t != "jpeg" && t != "jpg" && t != "png" && t != "bmp" && t != "gif")
	{
		document.getElementById(id).value='';
		return false;
	}
	return true;
}

function validateImage()
{
	var formData = new FormData();
	var file = document.getElementById("deposit-slip").files[0];
	formData.append("Filedata",file);
	var t = file.type.split('/').pop().toLowerCase();
	if(t != "jpeg" && t != "jpg" && t != "png" && t != "bmp" && t != "gif")
	{
		document.getElementById("img").value='';
		return false;
	}
	return true;
}

depositSlip.onchange = function()
{
	if(validateImage('deposit-slip'))
	{
		requiredText[13].innerHTML = ""
		depositSlip.setAttribute("style", "background-color: #FFFFFF;");
	}else
	{
		requiredText[13].innerHTML = "Please select a valid image file"
		depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
}

bankService.onchange = function()
{
	if(bankService.value == "" || bankService.value == null)
	{
		requiredText[4].innerHTML = "Please Select a bank service"
		bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[4].innerHTML = ""
		bankService.setAttribute("style", "background-color: #FFFFFF;");		
	}
}


depositSlip.onblur = function()
{
	if(depositSlip.value == "" || depositSlip.value == null)
	{
		requiredText[5].innerHTML = "Please provide the deposit slip"
		depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
}

mobileService.onchange = function()
{
	if(mobileService.value == "" || mobileService.value == null)
	{
		requiredText[2].innerHTML = "Please Select a mobile service"
		mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[2].innerHTML = ""
		mobileService.setAttribute("style", "background-color: #FFFFFF;");		
	}
}

referenceNo.onblur = function()
{
	if(referenceNo.value == "" || referenceNo.value == null)
	{
		requiredText[3].innerHTML = "Please provide reference/transtaction number"
		referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[3].innerHTML = ""
		referenceNo.setAttribute("style", "background-color: #FFFFFF;");	
	}
}