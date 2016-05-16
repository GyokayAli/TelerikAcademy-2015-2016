/**
 * Problem 1. Odd or Even
 * Write an expression that checks if given integer is odd or even.
 */

/** function to check if a given number is odd or even*/
function isOdd(num){
    return Boolean(num & 1);
}

/** test*/
for (var i = -3; i <= 3; i++){
    console.log(i + ' is odd? ' + isOdd(i));
}
