/**
 * Problem 7. Binary search
 * Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

var arr = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13, 14, 15];

// sort numbers in array
arr.sort(function (a, b) {
    return a - b;
});

console.log('Sorted array: \n' + arr);

function binarySearch(numbers, key, first, last) {
    while (last >= first) {
        var mid = parseInt((first + last) / 2);
        if (numbers[mid] < key) {
            first = mid + 1;
        } else if (numbers[mid] > key) {
            last = mid - 1;
        } else {
            console.log(key + ' is at index ' + mid);
            break;
        }
    }
}

// test -->> 0 is the start point, and 4 the key
binarySearch(arr, 4, 0, arr.length - 1);
