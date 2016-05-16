/**
 * Problem 4. Has property
 * Write a function that checks if a given object contains a given property.
 */

var person = {
    fname: 'Shopski',
    lname: 'Gangsta',
    occupation: '.NET Dev'
};

function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}

console.log(person);
console.log('occupation: ' + hasProperty(person, 'occupation'));
console.log('gender: ' + hasProperty(person, 'gender'));
person.gender = 'male';
person.age = 23;
console.log(person);
console.log('gender: ' + hasProperty(person, 'gender'));
console.log('age: ' + hasProperty(person, 'age'));


