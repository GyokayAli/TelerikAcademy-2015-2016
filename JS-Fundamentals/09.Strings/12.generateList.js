/**
 * Problem 12. Generate list
 * Write a function that creates a HTML <ul> using a template for every HTML <li>.
 * The source of the list should be an array of elements.
 * Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 */
//NOTE: run through index.html
var people = [
        {name: 'Jack', age: 18},
        {name: 'Davie', age: 43},
        {name: 'James', age: 21},
        {name: 'Dhruv', age: 20},
        {name: 'Rokas', age: 21}],
    template = document.getElementById('list-item').innerHTML;

function generateList() {
    var ul = document.createElement('ul');

    for (var ind in people) {
        var li = document.createElement('li');
        li.innerHTML = format(template, people[ind]);
        ul.appendChild(li);
    }
    document.body.appendChild(ul);
};

function format(string, person) {
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop] || '';
    });
}