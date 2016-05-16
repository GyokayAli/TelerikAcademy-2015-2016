/**
 * Problem 6. Larger than neighbours
 * Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */
var position = 7,
    numbers = [1, 2, 3, 4, 5, 5, 6, 7, 6, 5, 4, 3, 2, 1];

function isLargerThanNeighbours(arr, pos) {
    var isGreater = false;
    if (pos < arr.length && pos > 0) {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1]) //check neighbours
        {
            isGreater = true;
        }
    }
    else {
        console.log('There are no neighbours to compare ');
    }
    return isGreater;
}

// test
console.log('Is larger? --> ' + isLargerThanNeighbours(numbers, position));
