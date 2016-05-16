/**
 * Problem 1. Make person
 * Write a function for creating persons.
 * Each person must have firstname, lastname, age and gender (true is female, false is male)
 * Generate an array with ten person with different names, ages and genders
 */
console.log('\nProblem 1 \n');

function Person(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}
var people = [
    new Person('Ivo', 'Ivanov', 16, false),
    new Person('Maria', 'Georgieva', 30, true),
    new Person('Marin', 'Petrov', 18, false),
    new Person('Kalina', 'Kolarova', 20, true),
    new Person('Georgi', 'Georgiev', 50, false),
    new Person('Valentina', 'Kolarova', 70, true),
    new Person('Martin', 'Marinov', 25, false),
    new Person('Asen', 'Ivanov', 14, false),
    new Person('Boris', 'Petrov', 81, false),
    new Person('Gergana', 'Borisova', 21, true)
];

people.forEach(function (item) {
    console.log(item);
});

//********************************************************************************************************
/**
 * Problem 2. People of age
 * Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 * Use only array methods and no regular loops (for, while)
 */
console.log('\nProblem 2 \n');

people.every(function (item) {
    return console.log('With age 18 or greater? ', item.age >= 18);
});

//********************************************************************************************************
/**
 * Problem 3. Underage people
 * Write a function that prints all underaged persons of an array of person
 * Use Array#filter and Array#forEach
 * Use only array methods and no regular loops (for, while)
 */
console.log('\nProblem 3 \n');

people.filter(function (item) {
    return item.age < 18;
}).forEach(function (item) {
    return console.log(item);
});

//********************************************************************************************************
/**
 * Problem 4. Average age of females
 * Write a function that calculates the average age of all females, extracted from an array of persons
 * Use Array#filter
 * Use only array methods and no regular loops (for, while)
 */
console.log('\nProblem 4 \n');

var femaleAgeAvg = people.filter(function (item) {
    return item.gender;
}).reduce(function (sum, item, i, arr) {
    var len = arr.length;
    return (sum + item.age / len);
}, 0);

console.log(femaleAgeAvg);

//********************************************************************************************************
/**
 * Problem 5. Youngest person
 * Write a function that finds the youngest male person in a given array of people and prints his full name
 * Use Array#find
 * Use only array methods and no regular loops (for, while)
 */
console.log('\nProblem 5 \n');

if (!Array.prototype.find) {
    Array.prototype.find = function (item) {
        var i,
            len = this.length;
        for (i = 0; i < len; i += 1) {
            if (item(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    people.sort(function (a, b) {
        return a.age - b.age;
    }).find(function (item) {
        return !item.gender;
    });

console.log('Age: ', youngestMale.age);
console.log(youngestMale.firstname, youngestMale.lastname);

//********************************************************************************************************
/**
 * Problem 6. Group people
 * Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 * Use Array#reduce
 * Use only array methods and no regular loops (for, while)
 */
console.log('\nProblem 6 \n');

