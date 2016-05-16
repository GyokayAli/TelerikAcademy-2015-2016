/**
 * Problem 3. Min/Max of sequence
 * Write a script that finds the max and min number from a sequence of numbers.
 */

var numbers = [0, 9, 10, 12, 19, 25, 98, 98, 273, 400, 501, 617, 711, 999];

// version 1
var min = Math.min.apply(Math, numbers);
var max = Math.max.apply(Math, numbers);
console.log('Minimum ' + min + '\nMaximum ' + max);

console.log();

// version 2
var maxIndex = 0;
var minIndex = 0;
for (var i = 0; i < numbers.length; i++) {
    if (numbers[maxIndex] < numbers[i]) {
        maxIndex = i;
    }
    if (numbers[i] < numbers[minIndex]) {
        minIndex = i;
    }
}
console.log('Minimum ' + numbers[minIndex] + '\nMaximum ' + numbers[maxIndex]);
