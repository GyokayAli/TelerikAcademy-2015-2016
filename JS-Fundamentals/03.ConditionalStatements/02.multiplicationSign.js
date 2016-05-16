/**
 * Problem 2. Multiplication Sign
 * Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of if operators.
 */

// function to determine number's sign
function getSign(a, b, c) {
    if (a === 0 && b === 0 && c === 0) {
        console.log('0');
    } else if (a > 0 && b > 0 && c > 0) {
        console.log('+');
    } else if (a < 0 && b < 0 && c < 0) {
        console.log('-');
    } else if (a < 0 && b < 0 && c > 0) {
        console.log('+');
    } else if (a < 0 && b > 0 && c < 0) {
        console.log('+');
    } else if (a > 0 && b < 0 && c < 0) {
        console.log('+');
    } else if (a < 0 && b > 0 && c > 0) {
        console.log('-');
    } else if (a > 0 && b < 0 && c > 0) {
        console.log('-');
    } else if (a > 0 && b > 0 && c < 0) {
        console.log('-');
    } else {
        console.log('0');
    }
}

// test
getSign(5, 2, 2);
getSign(-2, -2, 1);
getSign(-2, 4, 3);
getSign(0, -2.5, 4);
getSign(-1, -0.5, -5.1);
