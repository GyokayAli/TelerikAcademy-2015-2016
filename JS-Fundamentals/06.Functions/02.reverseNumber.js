/**
 * Problem 2. Reverse number
 * Write a function that reverses the digits of given decimal number.
 */

function reverseDecimal(decimal) {
    var reversed = [],
        number = decimal.toString().replace('-', '').split('');
    Array.prototype.push.apply(reversed, number.reverse());
    return reversed.join('');
}

// test
console.log(reverseDecimal(256));
console.log(reverseDecimal(123.45));

