/**
 * Problem 3. Maximal sequence
 * Write a script that finds the maximal sequence of equal elements in an array.
 */

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var len = sequence.length;

function maxEqualSequence(arr) {
    var best = [arr[0]],
        tmp = [arr[0]];

    for (var i = 1; i < len; i += 1) {
        if (arr[i] !== tmp[0]) {
            tmp = [arr[i]];
        } else {
            tmp.push(arr[i]);
        }

        if (tmp.length > best.length) {
            best = tmp;
        }
    }

    return best;
}

// test
console.log(maxEqualSequence(sequence).join(', '));
