/**
 * Problem 9. Point in Circle and outside Rectangle
 * Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

var radius = 3;

function inCircleOutRect(x, y) {
    var inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
    var inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

    return inCircle && !inRectangle ? 'yes' : 'no';
}

/** test */
var myString = 'inside K & outside of R -> '
console.log(myString + inCircleOutRect(1,4));
console.log(myString + inCircleOutRect(3,2));
console.log(myString + inCircleOutRect(0,1));
console.log(myString + inCircleOutRect(4,1));
console.log(myString + inCircleOutRect(2,0));
console.log(myString + inCircleOutRect(4,0));
console.log(myString + inCircleOutRect(2.5,1.5));
console.log(myString + inCircleOutRect(3.5,1.5));
console.log(myString + inCircleOutRect(-100,-100));