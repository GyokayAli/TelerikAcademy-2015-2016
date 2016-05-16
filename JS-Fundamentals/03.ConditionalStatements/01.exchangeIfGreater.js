/**
 * Problem 1. Exchange if greater
 * Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 * As a result print the values a and b, separated by a space.
 */

// function to check the bigger number and swap places
function isBigger(a, b) {
    if (a > b) {
        var tmp = a;
        a = b;
        b = tmp;
    }
    console.log(a + ' ' + b);
}

// test
isBigger(5, 2);
isBigger(3, 4);
isBigger(5.5, 4.5);

