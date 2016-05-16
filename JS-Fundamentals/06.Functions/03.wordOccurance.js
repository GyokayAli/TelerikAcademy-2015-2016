/**
 * Problem 3. Occurrences of word
 * Write a function that finds all the occurrences of word in a text.
 * The search can be case sensitive or case insensitive.
 * Use function overloading.
 */

function searchWord(text, word) {
    word = word.toLowerCase();
    text = text.toLowerCase();

    var occur = 0;
    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === word[0]) {
            var equal = false;
            for (var j = 0; j < word.length; j += 1) {
                if (text[i + j] === word[j]) {
                    equal = true;
                } else {
                    equal = false;
                    break;
                }
            }
            if (equal) {
                occur++;
            }
        }
    }
    return occur;
}

// test
var text = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.';
console.log(searchWord(text, 'et'));
console.log(searchWord(text, 'ut'));
