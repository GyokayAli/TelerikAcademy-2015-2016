/**
 * Problem 7. Is prime
 * Write an expression that checks if given positive integer number n (n ? 100) is prime.
 */


/** function to check if a number is prime or not */
function isPrime(n) {
    var prime = true;
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) {
            prime = false;
        }
    }
    if (n == 1 || n <= 0)
        prime = false;

    return prime;
}

/** test */
var n = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
for (var num in n) {
    console.log(n[num] + ' is prime ? -> ' + isPrime(n[num]));
}