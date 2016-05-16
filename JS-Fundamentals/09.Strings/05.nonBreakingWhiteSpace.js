/**
 * Problem 5. nbsp
 * Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

var text = 'We are   living in a yellow submarine. We don\'t have anything   else.';

function replaceAll (text, toReplace, replacement) {
    var regex = new RegExp(toReplace, 'gi');
    return text.replace(regex, replacement);
}

text = replaceAll(text, ' ', '&nbsp;');
console.log(text);
