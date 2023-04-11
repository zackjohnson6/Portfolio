// hover event. Trivia answer will display when the cursor moves over the image.
hover.addEventListener("mouseover", function(){
    display.textContent = "Answer: Walter Payton";    
    });

// click event. Answer will display when the user clicks the image. 
click.addEventListener("click", function(){
    msg.textContent= "Answer: 20! 14 punt returns, 5 kickoff returns, and 1 missed field goal."    
    });

//double click event. Answer will display when the user clicks the image twice.
double.addEventListener("dblclick", function(){
    finish.textContent="Answer: Jay Cutler! Cutler threw for 23,443 yards in 102 games with the Chicago Bears."    
    });

//mouseout event. Answer will display after the user moves the cursor over the image, and back out again.
out.addEventListener("mouseout", function(){
    done.textContent="Answer: Soldier Field! The Bears have played here since 1975, and it was completely renovated in 2003."    
    });