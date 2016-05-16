/**
 * Problem 4. Third digit
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */

/** function to check if given number's third digit is 7 */
function isDigitSeven(number) {
    return (Math.floor(number / 100) % 10) === 7 ? true : false;
}

/** test */
var digits = [5, 701, 1732, 9703, 877, 777877, 9999799];
for (var digit in digits) {
    console.log('Third digit (right-to-left) of ' + digits[digit] + ' is 7 -> ' + isDigitSeven(digits[digit]));
}



