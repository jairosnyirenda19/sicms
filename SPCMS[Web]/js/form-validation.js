//Form wizard	

var FormIndex;
var username = document.getElementById("username");
var password = document.getElementById("password");
var conPass = document.getElementById("confirm");
var firstname = document.getElementById("name");
var surname = document.getElementById("surname");
var contact = document.getElementById("contact");
var _email = document.getElementById("email");
var unameTaken = "Username already taken. Please choose another one";

var requiredText = document.getElementsByClassName("required-text");

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


window.onload = function() 
{
	FormIndex = 1;
	showForm(FormIndex);
	wizard(FormIndex);
};
	
function plusIndex(n)
{
	showForm(FormIndex += n);
	wizard(FormIndex);
}

function showForm(n)
{
	var form = document.getElementsByClassName("slide");
	if(n > form.length)
	{
		FormIndex = 1;
	}
	if(n < 1)
	{
		FormIndex = form.length;
	}

	for (var i = 0; i < form.length; i++) {		
		form[i].style.display = "none";
	}
	form[FormIndex-1].style.display = "block";
}

function wizard(n)
{
	var tab = document.getElementsByClassName("tab");
	for (var i = n; i < tab.length; i++) 
	{		
		tab[i].style.background = "#454545";
	}
	tab[FormIndex-1].style.background = "#1BBB36";			
}

// Validation
		
function AccountValidate(n) {
	if(username.value == "" && password.value == "" && conPass.value == "")
	{
	 	username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	for (var i = 0; i < 3; i++) {
	 		requiredText[i].innerHTML = "This field is required."; 		
	 	}
	}
	else if (username.value == "")
	{
		requiredText[0].innerHTML = "This field is required."; 
	 	username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
	else if(password.value == "")
	{
		requiredText[1].innerHTML = "This field is required."; 
	 	password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}
	else if(conPass.value == "")
	{	
		requiredText[2].innerHTML = "This field is required."; 	
		conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else
	{
		if(username.value != "" && password.value != "" && conPass.value != "")
		{
			if(password.value != conPass.value)
			{
				conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
				requiredText[2].innerHTML = "This field should match the password.";
			}else if(requiredText[0].value == unameTaken)
			{
				username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			}
			else
			{
				if(unameTaken != requiredText[0].innerHTML){
					username.setAttribute("style", "background-color: #FFFFFF;");
					conPass.setAttribute("style", "background-color: #FFFFFF;");
					requiredText[2].innerHTML = "";	
					plusIndex(n);
				}
			}
		}
	}			
}



function ProfileValidate(n)
{
	if (firstname.value == "" && surname.value == "" && contact.value == "") 
	{
	 	firstname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		surname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	contact.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	for (var i = 2; i < requiredText.length; i++) 
	 	{
	 		requiredText[i].innerHTML = "This field is required.";
	 		if (i == 5) 
	 		{
	 			break;
	 		}	
	 	}		
	} else if(firstname.value == "")
	{
	 	firstname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");	
	 	requiredText[3].innerHTML = "This field is required."	
	}else if(surname.value == "")
	{
	 	surname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	requiredText[4].innerHTML = "This field is required."			
	}else if(contact.value == "")
	{
		contact.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[5].innerHTML = "This field is required."	
	}else
	{
		if(firstname.value != "" && surname.value != "" && contact.value != "")
		{
			if(!validateContact(contact.value))
			{
				contact.setAttribute("style", "background-color: #FBC1C3;");
				requiredText[5].innerHTML = "Invalid contact number.";
			}
			else
			{
				contact.setAttribute("style", "background-color: #FFFFFF;");
				requiredText[5].innerHTML = "";	
				plusIndex(n);
			}
		}
	}
}

username.onblur = function() {	
	if(username.value == "")
	{
		username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	requiredText[0].innerHTML = "This field is required.";
	}else if(username.value.length < 2)
	{
		username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	requiredText[0].innerHTML = "Username is too short, should be at least 2 Characters";
	}else if(username.value.length > 20)
	{
		username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	 	requiredText[0].innerHTML = "Username is too long, maximum Characters are 20";
	}
	else
	{	
		var uTaken = document.getElementById("usernameFailed");
		if(unameTaken != uTaken.innerHTML)
		{
			username.setAttribute("style", "background-color: #FFFFFF;");
			requiredText[0].innerHTML = "";
		}else
		{
			username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");			
		}
	}
};

username.onkeyup = function()
{
	var uTaken = document.getElementById("usernameFailed");
	if(unameTaken == uTaken.innerHTML)
	{
		username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
	}else if(unameTaken != uTaken.innerHTML)
	{
		username.setAttribute("style", "background-color: #FFFFFF;");		
	}else{}
}

password.onblur = function() {
	if(password.value == "")
	{
		password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[1].innerHTML = "This field is required.";
	}else if(password.value.length < 6)
	{
		password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[1].innerHTML = "Password is too short, should be at least 6 Characters";
	}
	else 
	{
		password.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[1].innerHTML = "";
	} 
};

conPass.onblur = function() {
	if (password.value != "") 
	{
		conPass.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[2].innerHTML = "";
	} 
	else 
	{
		conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[2].innerHTML = "This field is required.";
	}
};

conPass.onkeyup = function() {
	if(conPass.value == "")
	{
		conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[2].innerHTML = "This field is required.";
	}
	else if(conPass.value != "" && conPass.value != password.value)
	{
		conPass.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[2].innerHTML = "This field should match the password.";
	}else
	{
		conPass.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[2].innerHTML = "";		
	}
};

firstname.onblur = function()
{
	if(firstname.value == "")
	{
		firstname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[3].innerHTML = "This field is required.";
	}else
	{
		firstname.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[3].innerHTML = "";		
	}
};

surname.onblur = function()
{
	if(surname.value == "")
	{
		surname.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[4].innerHTML = "This field is required.";
	}else
	{
		surname.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[4].innerHTML = "";		
	}
};

contact.onblur = function(){
	if(contact.value == "")
	{
		contact.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[5].innerHTML = "This field is required.";
	}else
	{
		contact.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[5].innerHTML = "";		
	}	
};

contact.onkeypress = function() {
	ContactEntry();
};

contact.onkeyup = function() {
		
	if(contact.value.length > 14)
	{
		contact.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
		requiredText[5].innerHTML = "Invalid contact number.";
	}
	else
	{
		contact.setAttribute("style", "background-color: #FFFFFF;");
		requiredText[5].innerHTML = "";		
	}
};

_email.onblur = function(){
	if(_email.value != "")
	{
	   	var e = document.forms[0].email.value;
		var i = validateEmail(e);
		if(!i)
		{
			requiredText[6].innerHTML = "Invalid email. Please enter a correct email.";			
		}else
		{
			requiredText[6].innerHTML = "";			
		}
	}else
	{
		requiredText[6].innerHTML = "";			
	}
};

function validateEmail(email)
{
   atpos = email.indexOf("@");
   dotpos = email.lastIndexOf(".");

   if (atpos < 1 || ( dotpos - atpos < 2 )) 
   {
       return false;
   }
   return( true );
}

function validateContact(contact) {
	if (contact.length != 14)
	{
		return false;
	}else
	{
		var number = "";
		for (var i = 0; i < contact.length; i++) {
			if(contact[i] != "(" && contact[i] != ")" && contact[i] != "-")
			{
				number += contact[i];
			}
		}
		if (isNaN(number)) 
		{
			return false;
		}
	}
	return ( true );
}


function ContactEntry()
{
	if(contact.value.length == 1)
	{
		contact.value = "("+contact.value;
	}else if(contact.value.length == 4)
	{
		contact.value = contact.value+")-";	
	}
	else if(contact.value.length == 9)
	{
		contact.value = contact.value+"-";
	}
}


