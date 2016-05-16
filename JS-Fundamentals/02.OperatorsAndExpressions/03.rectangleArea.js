/**
 * Problem 3. Rectangle area
 * Write an expression that calculates rectangle’s area by given width and height.
 */

/** Rectangle area formula A = length * width */

/** function to find the area of a rectangle */
function rectArea(width, length) {
    var area = width * length;
    return console.log('Rectangle with width=' + width + ' and length=' + length + ' has AREA = ' + area);
}
/** test */
rectArea(3, 4);
rectArea(2.5, 3);
rectArea(5, 5);



