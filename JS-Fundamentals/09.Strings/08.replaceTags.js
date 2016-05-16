/**
 * Problem 8. Replace tags
 * Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

var inputHTML = '<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>';
console.log(inputHTML);

inputHTML = inputHTML.replace("<a href=\"", "[URL=");
inputHTML = inputHTML.replace("</a>", "[/URL]");
inputHTML = inputHTML.replace("\">", "]");

console.log('\nOutput string:');
console.log(inputHTML);