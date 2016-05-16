/**
 * Problem 2. Lexicographically comparison
 * Write a script that compares two char arrays lexicographically (letter by letter).
 */

function compareLexicographically(arr1, arr2) {
    var isEqual = true;
    if (arr1.length === arr2.length) {
        for (var i = 0; i < arr1.length; i++) {
            if (arr1[i] !== arr2[i]) {
                isEqual = false;
                break;
            }
        }
    }
    console.log('Char arrays are equal? --> ' + isEqual);
}

// test
compareLexicographically(['n', 'c', 'o'], ['n', 'c', 'o']);
compareLexicographically(['a', 'c'], ['a', 'b']);