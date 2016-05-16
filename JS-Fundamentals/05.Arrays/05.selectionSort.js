/**
 * Problem 5. Selection sort
 * Sorting an array means to arrange its elements in increasing order.
 * Write a script to sort an array.
 * Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 * Hint: Use a second array
 */

var numbers = [2, 1, 5, 3, 10, 9, 4, 7, 8, 6];

// function that implements the selection sort algorithm
function selectionSort(arr) {
    var len = arr.length;
    for (var i = 0; i < len; i++) {
        for (var j = i + 1; j < len; j++) {
            if (arr[i] > arr[j]) {
                var tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}
console.log('Before sorting: \n' + numbers);
// sort
selectionSort(numbers);
// check result
console.log('After sorting: \n' + numbers);

