/**
 * Problem 1. JavaScript literals
 * Assign all the possible JavaScript literals to different variables.
 *
 * Problem 4. Typeof null
 * Create null, undefined variables and try typeof on them.
 *
 * Problem 3. Typeof variables
 * Try typeof on all variables you created.
 */

var string = 'Hello world!';
var int = 51;
var float = 31.1;
var arr = [1, 2, 3];
var object = {course: 'JS', part: 'Data types and Variables'};
var nullValue = null;
var undefinedValue = undefined;
var boolean = true;

var variables = [int, float, string, boolean, arr, object, nullValue, undefinedValue];

for(var variable in variables){
    console.log(getTypeString(variables[variable]));
}

function getTypeString(obj){
    var result = obj;
    result += ' is ' + typeof obj;
    return result;
}