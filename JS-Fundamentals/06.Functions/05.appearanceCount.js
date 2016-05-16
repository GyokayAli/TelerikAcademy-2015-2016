/**
 * Problem 5. Appearance count
 * Write a function that counts how many times given number appears in given array.
 * Write a test function to check if the function is working correctly.
 */

function appearanceCounter(array, num) {
    var counter = 0;
    for (var n in array) {

        if (array[n] == num) {
            counter += 1;
        }
    }
    return counter;
}

// test
var numbers = [1, 2, 3, 4, 5, 5, 6, 7, 6, 5, 4, 3, 2, 1];
console.log(appearanceCounter(numbers, 5));
