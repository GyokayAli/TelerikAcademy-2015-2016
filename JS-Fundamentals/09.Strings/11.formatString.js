/**
 * Problem 11. String format
 * Write a function that formats a string using placeholders.
 * The function should work with up to 30 placeholders and all types.
 */

function format(){
    var args = arguments,
        string = args[0],
        placeholder;

    for (var i = 1; i < args.length; i+=1) {
        placeholder ='{' + (i - 1) + '}';

        while(string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[i]);
        }
    }

    return string;
}

console.log(format('{0}, {1}, {0} text {2}',  1, 'John', 'Malkovich'));
