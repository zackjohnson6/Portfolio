// this script will cause the images on the html page to fade in and out at regular intervals of 1000ms. 

$("#slideshow div:gt(0)").hide();

setInterval(function(){
    $('#slideshow div:first')
    .fadeOut(1000)
    .next()
    .fadeIn(1000)
    .end()
    .appendTo('#slideshow');

}, 3000)

