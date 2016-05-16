/**
 * Problem 6. Quadratic equation
 * Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 * Calculates and prints its real roots.
 * Note: Quadratic equations may have 0, 1 or 2 real roots.
 */

// function to solve a given quadratic equation
function solveQuadFunction(a,b,c){
    var d = Math.pow(b, 2) - 4 * a * c; //discriminant of the quadratic polynomial

    if (d < 0) {
        console.log('no real roots');
    }
    else if (d == 0) {
        var x = -b / (2 * a);
        console.log('x1 = x2 =', x);
    }
    else {
        var root1 = (-b - Math.sqrt(d)) / (2 * a);
        var root2 = (-b + Math.sqrt(d)) / (2 * a);
        console.log('x1 = ' + root1 + ' and x2 = ' + root2);
    }
}

// test
solveQuadFunction(2,5,-3);
solveQuadFunction(-1,3,0);
solveQuadFunction(-0.5,4,-8);
solveQuadFunction(5,2,8);
