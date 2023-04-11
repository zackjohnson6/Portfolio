//stores the header's text in a variable Using a DOM api
var headerText = document.querySelector('.header').textContent

//finds the number of paragraphs in the page Using a DOM api
var pCount = document.getElementsByTagName('p').length

//Using a DOM api, gets the number of heading tags used in the document
var headingCount = document.querySelectorAll('h2,h3,h4,h5,h6').length

//these write the number of headings, paragraphs, and the header text onto the page.
document.write('The header text is ' + headerText + "<br> <br>")

document.write('This article contains ' + pCount + ' paragraphs, and a total of ' + headingCount + ' headings tags.'+ '<br> <br>')
