/**
 * Problem 5. Third bit
 * Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */

var pos = 3;
/** function to find a number at given position (1 or 0) BINARY */
function checkBit(n) {
    return ((n >> pos) & 1) == 1 ? 1 : 0;
}

/** test */
var n = [5, 8, 0, 15, 5343, 62241];
for (var bit in n) {
    console.log('The bit at position ' + pos + ' of ' + n[bit] + '(' + n[bit].toString(2) + ') is: ' + checkBit(n[bit]));
}