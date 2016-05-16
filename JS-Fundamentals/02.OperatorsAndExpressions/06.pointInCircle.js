/**
 * Problem 6. Point in Circle
 * Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
 */

var radius = 5;
/** function to check if the given values are in the circle */
function isInside(x, y) {
    return Boolean((x - 0) * (x - 0) + (y - 0) * (y - 0) <= radius * radius) ? true : false;
}

/** test */
var myString = 'X and Y are in the circle ? - > ';
console.log(myString + isInside(0,1));
console.log(myString + isInside(-5,0));
console.log(myString + isInside(-4,5));
console.log(myString + isInside(1.5,-3));
console.log(myString + isInside(-4,-3.5));
console.log(myString + isInside(100,-30));
console.log(myString + isInside(0,0));
console.log(myString + isInside(0.2,-0.8));
console.log(myString + isInside(0.9,-4.93));
console.log(myString + isInside(2,2.655));



