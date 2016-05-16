/**
 * Problem 3. Deep copy
 * Write a function that makes a deep copy of an object.
 * The function should work for both primitive and reference types.
 */

function deepCopy(obj){
    if(typeof obj !== 'object'){
        return obj;
    }

    var copy = {};
    for(var prop in obj){
        copy[prop] = deepCopy(obj[prop]);
    }

    return copy;
}

console.log(deepCopy(9999));
console.log(deepCopy('string'));
console.log(deepCopy({fname: 'Peter', lname: 'Cowboyski'}));
