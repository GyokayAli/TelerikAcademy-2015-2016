/**
 * Problem 6. Extract text from HTML
 * Write a function that extracts the content of a html page given as text.
 * The function should return anything that is in a tag, without the tags.
 Example:
 <html>
 <head>
 <title>Sample site</title>
 </head>
 <body>
 <div>text
 <div>more text</div>
 and more...
 </div>
 in body
 </body>
 </html>
 Result: Sample sitetextmore textand more...in body
 */

var htmlTxt = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

function getText(html) {
    return html.replace(/<[^>]*>/g, '');
}

var plainTxt = getText(htmlTxt);
console.log(plainTxt);







