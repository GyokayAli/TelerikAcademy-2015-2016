/**
 * Problem 2. Divisible by 7 and 5
 * Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */

/** function to check if a given number is divisible by 7 and 5 */
function isDivisible(num, divisor1, divisor2){
    return !((num % divisor1) || (num % divisor2));
}

/** test */
var testNums = [140,35,7,5,0,3];

for(var test in testNums){
console.log(testNums[test] + ' is divisible by 7 and 5? -> ' + isDivisible(testNums[test],7,5));
}
