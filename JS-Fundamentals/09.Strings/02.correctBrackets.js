/**
 * Problem 2. Correct brackets
 * Write a JavaScript function to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

function checkBrackets(expression) {
    var isCorrect = 0;

    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            isCorrect++;
        } else if (expression[i] === ')') {
            isCorrect--;
        }
        if (isCorrect < 0) {
            return 'incorrect';
        }
    }
    return isCorrect ? 'incorrect' : 'correct';
}

console.log('((a+b)/5-d) - ' + checkBrackets('((a+b)/5-d)'));
console.log(')(a+b)) - ' + checkBrackets(')(a+b))'));