var crop = document.getElementById("crop");
var variety = document.getElementById("variety");
var seedClass = document.getElementById("seedClass");
var srcSeed = document.getElementById("srcSeed");
var tagNo = document.getElementById("tagNo");
var billNo = document.getElementById("billNo");
var dateOfPurchase = document.getElementById("date-of-purchase");
var quantity = document.getElementById("quantity");
var acreage = document.getElementById("acreage");
var dateOfSowing = document.getElementById("date-of-sowing");
var mobileService = document.getElementById("mobile-service-select");
var referenceNo = document.getElementById("referenceNo");
var bankService = document.getElementById("bank-service-select");
var depositSlip = document.getElementById("deposit-slip");
var tagSource = document.getElementById("tag-source");
var purchaseBill = document.getElementById("purchase-bill");
var buttonName = document.getElementById("submit");
var requiredText = document.getElementsByClassName("required-text");
var editmode= false;

var getDaysInMonth = function(month, year)
{
	return new Date(year, month, 0).getDate();
};
var getYear = function(){
	return new Date().getFullYear();
};

var _getMonth = function(){
	return new Date().getMonth();
};

var _getDate = function(){
	return new Date().getDate();
};


window.addEventListener('keydown', function(e) {
	if (e.keyIdentifier == 'U+00A' || e.keyIdentifier == 'Enter' || e.keyCode == 13) 
	{
		if(e.target.nodeName == 'INPUT' && e.target.type == 'text')
		{
			e.preventDefault();
			return false;
		}
	}
}, true);



function comparedates(dateOne, dateTwo)
{
	if(dateOne > dateTwo)
	{
		return false;
	}else if(dateOne < dateTwo)
	{
		return true;
	}
	return true;
}


function validatedate(_date)
{
	//Test which seperator is used '/' or '-'
	var seperatorOne = _date.split('/');
	var seperatorTwo = _date.split('-');  
	var checkSeparatorOne = seperatorOne.length;  
	var checkSeparatorTwo = seperatorTwo.length;
	var actualDate;

		// Extract the string into month, date and year
	if(checkSeparatorOne > 1)
	{
		actualDate = _date.split('/');
	}
	else if(checkSeparatorTwo > 1)
	{	
		actualDate = _date.split('-');
	}

	if(actualDate.length > 1)
	{
		var yy = parseInt(actualDate[0]);
		var mm = parseInt(actualDate[1]);
		var dd = parseInt(actualDate[2]);	
		var daysInFebruary = getDaysInMonth(2, getYear());
		var ListofDays =[31, daysInFebruary ,31,30,31,30,31,31,30,31,30,31];

			if(mm == 1 || mm > 2)
			{	if(dd > ListofDays[mm-1])
				{
					return false;
				}
			}

			if(mm == 2)
			{
				var leapYear = false;
				if((!(yy % 4) && (yy % 100)) || !(yy % 400))
				{  
					leapYear = true;
				}
				if((leapYear == false) && (dd >= 29))
				{
					return false;
				}
				if((leapYear == true) && (dd > 29))
				{
					return false;
				}
			}		
	}else
	{
		return false;
	}
	return (true);
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


function ValidatePayment()
{
	if(document.getElementById("bank-service").checked)
	{
		if(bankService.value == "" || bankService.value == null)
		{
			requiredText[12].innerHTML = "Please Select a bank service"
			bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}

		if(depositSlip.value == "" || depositSlip.value == null)
		{
			requiredText[13].innerHTML = "Please provide the deposit slip"
			depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}else if(!validateImage('deposit-slip'))
		{
			requiredText[13].innerHTML = "Please select a valid image file";
			depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}
	}
	else if(document.getElementById("mobile-service").checked)
	{
		if(mobileService.value == "" || mobileService.value == null)
		{
			requiredText[10].innerHTML = "Please Select a mobile service"
			mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");			
			return false;
		}
		if(referenceNo.value == "" || referenceNo.value == null)
		{
			requiredText[11].innerHTML = "Please provide reference/transtaction number"
			referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}	
	}
	return true;
}

function ValidateSowingReport()
{
	if((crop.value == "" || crop.value == null) && (variety.value == "" || variety.value ==  null) && (seedClass.value == "" || seedClass.value == null) &&
		(srcSeed.value == "" || srcSeed.value == null) && (tagNo.value == "" || tagNo.value == null) && (billNo.value == "" || billNo.value == null) &&
		(dateOfPurchase.value == "" || dateOfPurchase.value == null) && (quantity.value == "" || quantity.value == null) && (acreage.value == "" || acreage.value == null) &&
		(dateOfSowing.value == "" || dateOfSowing.value == null) && (mobileService.value == "" || mobileService.value == null) && (referenceNo.value == "" || referenceNo.value == null) &&		
		(bankService.value == "" || bankService == null) && (depositSlip.value == "" || depositSlip.value == null) && (tagSource.value == "" || tagSource.value == null) &&
		(purchaseBill.value == "" || purchaseBill.value == null))
	{
		for (var i = 0; i < requiredText.length; i++) 
		{
			requiredText[i].innerHTML = "This field is required."; 	
		}
		crop.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		variety.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		seedClass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		srcSeed.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		tagNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		billNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		quantity.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		acreage.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		tagSource.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
		purchaseBill.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");



		return false;
	}
	else
	{
		if(crop.value == "" || crop.value == null)
		{
			requiredText[0].innerHTML = "Please Select a crop to be produced as seeds";
			crop.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}
		if(variety.value == "" || variety.value ==  null)
		{
			requiredText[1].innerHTML = "Please Select a variety of seeds to be produced";
			variety.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}
		if(seedClass.value == "" || seedClass.value == null)
		{
			requiredText[2].innerHTML = "Please Select a Seed Class";
			seedClass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");			
			return false;
		}
		if(srcSeed.value == "" || srcSeed.value == null)
		{
			requiredText[3].innerHTML = "Please provide the source of the seeds";
			srcSeed.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}
		if(tagNo.value == "" || tagNo.value == null)
		{
			requiredText[4].innerHTML = "Please provide the tag number of the seeds";
			tagNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}
		if(billNo.value == "" || billNo.value == null)
		{
			requiredText[5].innerHTML = "Please provide the purchase bill number of the seeds";
			billNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}

		if(dateOfPurchase.value == "" || dateOfPurchase.value == null)
		{
			requiredText[6].innerHTML = "Please provide an actual date of when the seeds where purchased";
			dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}	
		else if(!validatedate(dateOfPurchase.value))
		{
			requiredText[6].innerHTML = "Invalid date. Please provide an appropriate date";
			dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;		
		}else
		{
			var actualDate = dateOfPurchase.value.split('-');
			var yy = parseInt(actualDate[0]);
			var mm = parseInt(actualDate[1]);
			var dd = parseInt(actualDate[2]);	
				
			var dateTwo = new Date(getYear(),_getMonth()+1,_getDate());
			var dateOne = new Date(yy,mm,dd);

			if(!comparedates(dateOne, dateTwo))
			{
				requiredText[6].innerHTML = "Please provide a realistic date";
				dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
				return false;
			}
		}

		if(quantity.value == "" || quantity.value == null)
		{
			requiredText[7].innerHTML = "Please provide quantity of seeds sowen per acre";
			quantity.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
			return false;
		}else if(isNaN(quantity.value))
		{
			requiredText[7].innerHTML = "Invalid quantity. Please provide the number of the quantity";
			quantity.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
			return false;
		}
		if(acreage.value == "" || acreage.value == null)
		{
			requiredText[8].innerHTML = "Please provide acreage sowen per kg of the seeds";
			acreage.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
			return false;
		}else if(isNaN(acreage.value))
		{
			requiredText[8].innerHTML = "Invalid acreage. Please provide the number of Acreas"
			acreage.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;
		}

		if(dateOfSowing.value == "" || dateOfSowing.value == null)
		{
			requiredText[9].innerHTML = "Please provide an actual date of when sowing took place"
			dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");			
			return false;
		}
		else if(!validatedate(dateOfSowing.value))
		{
			requiredText[9].innerHTML = "Invalid date. Please provide an appropriate date"
			dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			return false;		
		}
		else
		{
			var actualDate = dateOfSowing.value.split('-');
			var yy = parseInt(actualDate[0]);
			var mm = parseInt(actualDate[1]);
			var dd = parseInt(actualDate[2]);	
			
			var dateTwo = new Date(getYear(),_getMonth()+1,_getDate());
			var dateOne = new Date(yy,mm,dd);

			if(!comparedates(dateOne, dateTwo))
			{
				requiredText[9].innerHTML = "Please provide a realistic date";
				dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
				return false;	
			}
		}

		if(!editmode)
		{
			if(!ValidatePayment())
			{
				return false;
			}

			if(tagSource.value == "" || tagSource.value == null)
			{
				requiredText[14].innerHTML = "Please provide the tag for the seed source"
				tagSource.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
				return false;
			}else if(!validateImage('tag-source'))
			{
				requiredText[14].innerHTML = "Please select a valid image file";
				tagSource.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
				return false;
			}

			if(purchaseBill.value == "" || purchaseBill.value == null)
			{
				requiredText[15].innerHTML = "Please provide purchase bill for the seeds";
				purchaseBill.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
				return false;
			}else if(!validateImage('purchase-bill'))
			{
				requiredText[15].innerHTML = "Please select a valid image file";
				purchaseBill.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
				return false;
			}
		}
	}

	return true;
}

buttonName.onclick = function() {
	editmode = (buttonName.getAttribute('name') == 'submit-edit') ? true : false;
}

crop.onchange = function()
{
	if(crop.value == "" || crop.value == null)
	{
		requiredText[0].innerHTML = "Please Select a crop to be produced as seeds"
		crop.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[0].innerHTML = ""
		crop.setAttribute("style", "background-color: #FFFFFF;");		
	}
}
variety.onchange = function()
{
	if(variety.value == "" || variety.value == null)
	{
		requiredText[1].innerHTML = "Please Select a variety of seeds to be produced"
		variety.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[1].innerHTML = ""
		variety.setAttribute("style", "background-color: #FFFFFF;");	
	}
}

seedClass.onchange = function()
{
	if(seedClass.value == "" || seedClass.value == null)
	{
		requiredText[2].innerHTML = "Please Select a Seed Class"
		seedClass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[2].innerHTML = ""
		seedClass.setAttribute("style", "background-color: #FFFFFF;");	
	}
}

srcSeed.onblur = function()
{
	if(srcSeed.value == "" || srcSeed.value == null)
	{
		requiredText[3].innerHTML = "Please provide the source of the seeds"
		srcSeed.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[3].innerHTML = ""
		srcSeed.setAttribute("style", "background-color: #FFFFFF;");	
	}
}

tagNo.onblur = function()
{
	if(tagNo.value == "" || tagNo.value == null)
	{
		requiredText[4].innerHTML = "Please provide the tag number of the seeds"
		tagNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[4].innerHTML = ""
		tagNo.setAttribute("style", "background-color: #FFFFFF;");	
	}
}

billNo.onblur = function()
{
	if(billNo.value == "" || billNo.value == null)
	{
		requiredText[5].innerHTML = "Please provide the purchase bill number of the seeds"
		billNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[5].innerHTML = ""
		billNo.setAttribute("style", "background-color: #FFFFFF;");	
	}
}


dateOfPurchase.onblur = function()
{
	if(dateOfPurchase.value == "" || dateOfPurchase.value == null)
	{
		requiredText[6].innerHTML = "Please provide an actual date of when the seeds where purchased"
		dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
	else if(!validatedate(dateOfPurchase.value))
	{
		requiredText[6].innerHTML = "Invalid date. Please provide an appropriate date"
		dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}else
	{
		var actualDate = dateOfPurchase.value.split('-');
		var yy = parseInt(actualDate[0]);
		var mm = parseInt(actualDate[1]);
		var dd = parseInt(actualDate[2]);	
			
		var dateTwo = new Date(getYear(),_getMonth()+1,_getDate());
		var dateOne = new Date(yy,mm,dd);

		if(comparedates(dateOne, dateTwo)){
			requiredText[6].innerHTML = ""
			dateOfPurchase.setAttribute("style", "background-color: #FFFFFF;");	
		}else
		{
			requiredText[6].innerHTML = "Please provide a realistic date"
			dateOfPurchase.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		}
	}
}


quantity.onblur = function()
{
	if(quantity.value == "" || quantity.value == null)
	{
		requiredText[7].innerHTML = "Please provide quantity of seeds sowen per acre"
		quantity.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else if(!isNaN(quantity.value))
	{
		requiredText[7].innerHTML = ""
		quantity.setAttribute("style", "background-color: #FFFFFF;");	
	}else
	{
		requiredText[7].innerHTML = "Invalid quantity. Please provide the number of the quantity"
		quantity.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
}

acreage.onblur = function()
{
	if(acreage.value == "" || acreage.value == null)
	{
		requiredText[8].innerHTML = "Please provide acreage sowen per kg of the seeds"
		acreage.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else if(!isNaN(acreage.value))
	{
		requiredText[8].innerHTML = ""
		acreage.setAttribute("style", "background-color: #FFFFFF;");	
	}else
	{
		requiredText[8].innerHTML = "Invalid acreage. Please provide the number of Acreas"
		acreage.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
}


dateOfSowing.onblur = function()
{
	if(dateOfSowing.value == "" || dateOfSowing.value == null)
	{
		requiredText[9].innerHTML = "Please provide an actual date of when sowing took place"
		dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
	else if(!validatedate(dateOfSowing.value))
	{
		requiredText[9].innerHTML = "Invalid date. Please provide an appropriate date"
		dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}else
	{
		var actualDate = dateOfSowing.value.split('-');
		var yy = parseInt(actualDate[0]);
		var mm = parseInt(actualDate[1]);
		var dd = parseInt(actualDate[2]);	
			
		var dateTwo = new Date(getYear(),_getMonth()+1,_getDate());
		var dateOne = new Date(yy,mm,dd);

		if(comparedates(dateOne, dateTwo)){
			requiredText[9].innerHTML = ""
			dateOfSowing.setAttribute("style", "background-color: #FFFFFF;");	
		}else
		{
			requiredText[9].innerHTML = "Please provide a realistic date"
			dateOfSowing.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		}
	}
}

mobileService.onchange = function()
{
	if(mobileService.value == "" || mobileService.value == null)
	{
		requiredText[10].innerHTML = "Please Select a mobile service"
		mobileService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[10].innerHTML = ""
		mobileService.setAttribute("style", "background-color: #FFFFFF;");		
	}
}

referenceNo.onblur = function()
{
	if(referenceNo.value == "" || referenceNo.value == null)
	{
		requiredText[11].innerHTML = "Please provide reference/transtaction number"
		referenceNo.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[11].innerHTML = ""
		referenceNo.setAttribute("style", "background-color: #FFFFFF;");	
	}
}


bankService.onchange = function()
{
	if(bankService.value == "" || bankService.value == null)
	{
		requiredText[12].innerHTML = "Please Select a bank service"
		bankService.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		requiredText[12].innerHTML = ""
		bankService.setAttribute("style", "background-color: #FFFFFF;");		
	}
}




depositSlip.onblur = function()
{
	if(depositSlip.value == "" || depositSlip.value == null)
	{
		requiredText[13].innerHTML = "Please provide the deposit slip"
		depositSlip.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
}


tagSource.onblur = function()
{
	if(tagSource.value == "" || tagSource.value == null)
	{
		requiredText[14].innerHTML = "Please provide the tag for the seed source"
		tagSource.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
}	


purchaseBill.onchange = function()
{
	if(purchaseBill.value == "" || purchaseBill.value == null)
	{
		requiredText[15].innerHTML = "Please provide purchase bill for the seeds"
		purchaseBill.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");		
	}
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



tagSource.onchange = function()
{
	if(validateImage('tag-source'))
	{
		requiredText[14].innerHTML = ""
		tagSource.setAttribute("style", "background-color: #FFFFFF;");
	}else
	{
		requiredText[14].innerHTML = "Please select a valid image file"
		tagSource.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
}


purchaseBill.onchange = function()
{
	if(validateImage('purchase-bill'))
	{
		requiredText[15].innerHTML = ""
		purchaseBill.setAttribute("style", "background-color: #FFFFFF;");
	}else
	{
		requiredText[15].innerHTML = "Please select a valid image file"
		purchaseBill.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
}


