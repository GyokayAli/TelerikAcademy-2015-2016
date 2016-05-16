/**
 * Problem 3. The biggest of Three
 * Write a script that finds the biggest of three numbers.
 * Use nested if statements.
 */

function biggestOfThree(a, b, c) {
    if (a > b) {
        if (a > c) {
            return console.log(a);
        }
        return console.log(c);
    }
    if (c > b) {
        return console.log(c);
    }
    return console.log(b);
}

// test
biggestOfThree(5, 2, 2);
biggestOfThree(-2, -2, 1);
biggestOfThree(-2,4,3);
biggestOfThree(0,-2.5,5);
biggestOfThree(-0.1, -0.5,-1.1);

