/*
Zack Johnson
CIS 133DA
Section 
27236
*/

//this statement should in theory display the date and time that the webpage was last modified
document.getElementById("lastmodified").innerHTML = document.lastModified;

//these functions will send the user an alert when they click the submit button, and will show a reset message when the "reset" button is clicked 

function submitalert() {
alert("Thank You for Contacting Us!");
}

function unhideReset() {
    document.getElementById("resetmessage").style.visibility = "visible";
}