/**
 * Problem 4. Maximal increasing sequence
 * Write a script that finds the maximal increasing sequence in an array.
 */

var sequence = [3, 2, 3, 4, 2, 2, 4];
var len = sequence.length;

function maxIncreasingSequence(arr) {
    var best = [arr[0]],
        tmp = [arr[0]];

    for (var i = 1; i < len; i++) {
        if (arr[i] > arr[i - 1]) {
            tmp.push(arr[i]);
        } else {
            tmp = [arr[i]];
        }

        if (tmp.length > best.length) {
            best = tmp;
        }
    }

    return best;
}

// test
console.log(maxIncreasingSequence(sequence).join(', '));

