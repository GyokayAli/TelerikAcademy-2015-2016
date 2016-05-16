/**
 * Problem 1. Reverse string
 * Write a JavaScript function that reverses a string and returns it.
 */

function reverse(str) {
    var i,
        reversed = '',
        len = str.length;
    for (i = len - 1; i > -1; i -= 1) {
        reversed += str.charAt(i);
    }
    return reversed;
}
// test
console.log('Reversed word -->> ',reverse('sample'));
