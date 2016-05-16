/**
 * Problem 6. Most frequent number
 * Write a script that finds the most frequent number in an array.
 */

var numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

var countNum = 0,
    counter = 1,
    maxCount = 1;

// sort array of numbers
numbers.sort();

var len = numbers.length;
for (var i = 0; i < len - 1; i += 1) {
    if (numbers[i] == numbers[i + 1]) {
        counter++;
    }
    else {
        counter = 1;
    }
    if (counter > maxCount) {
        maxCount = counter;
        countNum = numbers[i];
    }
}

if (maxCount > 1) {
    console.log(countNum + ' (' + maxCount + ' times)');
}
else {
    console.log('\nplease try again!');
}
