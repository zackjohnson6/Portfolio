//fact 1. Subtracts 2 from 1 to get 1 as the output. 
function superBowl(){
    var game = 2;
    return game - 1;    
    } 
    prob1.textContent= 'The Bears have been to 2 Super Bowls, winning ' + superBowl() + ', in 1985.';

//fact 2. subtracts 18 from 30 for an output of 12. 
function retired(){
    var player = 30
    return player - 18
}
prob2.textContent = 'Of the 30 Bears players in the Hall of Fame, ' + retired() + ' have had their jersey numbers retired by the team.'

// fact 3. Adds 1 to 782 to output 783, the number of all time wins by the Bears.
function wins(){
    var win = 782
    return win + 1
}
// subtracts 782 from 783 to output 1, which is the difference in all time wins between the Bears and Packers.
function difference(){
    var wins = 783
    return wins - 782
}
prob3.textContent = 'The Bears are the all time winningest NFL team with ' + wins() + ' victories. That is ' + difference() + ' more than the second place team, the Green Bay Packers.'

//fact 4. Multiplies 384 by 5 to get 1920, the year the Bears were founded. 
function year(){
    var time = 384
    return time * 5
}
prob4.textContent = 'The Chicago Bears were founded in ' + year() + ', and were originally named the Decatur Staleys. They are the oldest NFL franchise that is still currently playing.'

//fact 5. Subtracts 4 from 13 to get an output of 9, the number of NFL championships the bears have won.
function champ(){
    var trophy = 13
    return trophy - 4
}
prob5.textContent = 'Despite only winning ' + superBowl() + ' Super Bowl, the Bears have the second most all-time NFL Championship wins, with ' + champ() + ' overall. 8 of those wins came in the pre-Super Bowl era.'