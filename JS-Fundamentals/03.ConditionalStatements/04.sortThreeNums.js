/**
 * Problem 4. Sort 3 numbers
 * Sort 3 real values in descending order.
 * Use nested if statements.
 */

function sortThree(a, b, c) {
    if (a > b && a > c) {
        if (b <= c) {
            console.log(a, c, b);
        } else {
            console.log(a, b, c);
        }
    }
    if (b > a && b > c) {
        if (a <= c) {
            console.log(b, c, a);
        } else {
            console.log(b, a, c);
        }
    }
    if (c > a && c > b) {
        if (b <= a) {
            console.log(c, a, b);
        } else {
            console.log(c, b, a);
        }
    }
    if (a == b && a == c) {
        console.log(a, b, c);
    }
}

// test
sortThree(5, 1, 2);
sortThree(-2, -2, 1);
sortThree(-2, 4, 3);
sortThree(0, -2.5, 5);
sortThree(-1.1, -0.5, -0.1);
sortThree(10, 20, 30);
sortThree(1, 1, 1);