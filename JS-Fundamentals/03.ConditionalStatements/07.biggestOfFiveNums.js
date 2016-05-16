/**
 * Problem 7. The biggest of five numbers
 * Write a script that finds the greatest of given 5 variables.
 * Use nested if statements.
 */

// function to get the biggest of given 5 numbers
function getBiggestOfFive(a, b, c, d, e) {
    var max = Math.max();

    if (a > max) {
        max = a;
    }
    if (b > max) {
        max = b;
    }
    if (c > max) {
        max = c;
    }
    if (d > max) {
        max = d;
    }
    if (e > max) {
        max = e;
    }
    return console.log('The biggest of five numbers is ', max);
}

// test
getBiggestOfFive(5, 2, 2, 4, 1);
getBiggestOfFive(-2, -22, 1, 0, 0);
getBiggestOfFive(-2, 4, 3, 2, 0);
getBiggestOfFive(0, -2.5, 0, 5, 5);
getBiggestOfFive(-3, -0.5, -1.1, -2, -0.1);

