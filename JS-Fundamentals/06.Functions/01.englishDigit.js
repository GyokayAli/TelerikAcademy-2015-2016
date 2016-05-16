/**
 * Problem 1. English digit
 * Write a function that returns the last digit of given integer as an English word.
 */

function getLastDigitAsWord(number){
    var lastDigit = number % 10;
    var word = '';
    switch (lastDigit)
    {
        case 0: word = 'zero';
            break;
        case 1: word = 'one';
            break;
        case 2: word = 'two';
            break;
        case 3: word = 'three';
            break;
        case 4: word = 'four';
            break;
        case 5: word = 'five';
            break;
        case 6: word = 'six';
            break;
        case 7: word = 'seven';
            break;
        case 8: word = 'eight';
            break;
        case 9: word = 'nine';
            break;
    }
    console.log("Last digit as word is: " + word);
}

// test
getLastDigitAsWord(512);
getLastDigitAsWord(1024);
getLastDigitAsWord(12309);
