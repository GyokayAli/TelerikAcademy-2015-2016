/**
 * Problem 7. First larger than neighbours
 * Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 * Use the function from the previous exercise.
 */

var numbers = [1, 2, 3, 6, 5, 5, 6, 7, 6, 5, 4, 3, 2, 1];

function isLargerThanNeighbours(arr, pos) {
    var isGreater = false;
    if (pos < arr.length && pos > 0) {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1]) //check neighbours
        {
            isGreater = true;
        }
    }
    return isGreater;
}

function checkFirst(arr) {
    var count = 0;
    for (var i = 0; i < arr.length; i++) {
        if (isLargerThanNeighbours(arr, i)) {
            console.log('The index of the first element in array that is larger than its neighbours is: ', i);
            count++;
            return;
        }
    }
    if (count == 0) {
        console.log(-1);
    }
}

// test
checkFirst(numbers);