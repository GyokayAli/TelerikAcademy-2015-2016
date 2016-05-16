/**
 * Problem 5. Digit as word
 * Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 * Print “not a digit” in case of invalid input.
 * Use a switch statement.
 */

var numStr = ['2', '1', '0', '5', '-0.1', 'hi', '9', '10'];

for (var num in numStr) {
    switch (numStr[num]) {
        case "0":
            console.log(numStr[num],"zero"); break;
        case "1":
            console.log(numStr[num],"one"); break;
        case "2":
            console.log(numStr[num],"two"); break;
        case "3":
            console.log(numStr[num],"three"); break;
        case "4":
            console.log(numStr[num],"four"); break;
        case "5":
            console.log(numStr[num],"five"); break;
        case "6":
            console.log(numStr[num],"six"); break;
        case "7":
            console.log(numStr[num],"seven"); break;
        case "8":
            console.log(numStr[num],"eight"); break;
        case "9":
            console.log(numStr[num],"nine"); break;
        default:
            console.log(numStr[num],"not a digit"); break;
    }
}
