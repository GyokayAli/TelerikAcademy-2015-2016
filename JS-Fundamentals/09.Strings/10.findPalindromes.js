/**
 * Problem 10. Find palindromes
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

var palindromes = [],
    text = "ABBA, lamal, exe, cat, sos, dad, mom, hero",
    words = text.match(/\b\w+\b/g);

function isPalindrome(str)
{
    for (var i = 0; i < str.length / 2; i+=1)
    {
        if (str[i] != str[str.length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

function extractPalindrom(text){
    for(var i in words){
        if(isPalindrome(words[i])){
            palindromes.push(words[i]);
        }
    }
    return palindromes;
}

// test
console.log(extractPalindrom(text).join('; '));