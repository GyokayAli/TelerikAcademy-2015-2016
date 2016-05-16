/**
 * Problem 5. Youngest person
 * Write a function that finds the youngest person in a given array of people and prints his/hers full name
 * Each person has properties firstname, lastname and age.
 */

var people = [
    new Person('Billy', 'Boy', 18),
    new Person('Joe', 'Jordan', 55),
    new Person('Justin', 'The Beaver', 15),
    new Person('Peter', 'Petkanov', 33),
    new Person('Mad', 'Max', 99),
];

function Person(firstname, lastname, age) {
    if (isNaN(age) || !isFinite(age)) {
        throw new Error('age must be a number');
    }

    if (!(this instanceof  Person)) {
        return new Person(firstname, lastname, age);
    }

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
}

Person.prototype.toString = function(){
    return this.firstname + ' ' + this.lastname;
};

function comparePeople(a, b) {
    return a.age - b.age;
}

people.sort(comparePeople);

for (var person = 0; person < people.length; person++) {
    console.log(people[person]);
}

console.log('Youngest: ' + people[0].toString());

