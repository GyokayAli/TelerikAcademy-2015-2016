/**
 * Problem 8. Trapezoid area
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

/** Trapezoid area formula A = (a+b) / 2 * h */
function trapezoidArea(a, b, h) {
    return ((a + b) / 2) * h;
}

/** test */
console.log('Trapezoid area: ' + trapezoidArea(5, 7, 12));
console.log('Trapezoid area: ' + trapezoidArea(2, 1, 33));
console.log('Trapezoid area: ' + trapezoidArea(8.5, 4.3, 2.7));
console.log('Trapezoid area: ' + trapezoidArea(100, 200, 300));
console.log('Trapezoid area: ' + trapezoidArea(0.222, 0.333, 0.555));

