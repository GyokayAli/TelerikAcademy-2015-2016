/**
 * Problem 4. Parse tags
 * You are given a text. Write a function that changes the text in all regions:
 *
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)

 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */
var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. ' +
    'We <mixcase>don\'t</mixcase> have <lowcase>anYTHing</lowcase> else.';

console.log(text);
text = replaceTags(text);
text = parseTags(text);
console.log(text);

function replaceTags(text){
    text = text.replace(/<\s*upcase\s*>/gi, '<U>');
    text = text.replace(/<\s*\/upcase\s*>/gi, '</U>');
    text = text.replace(/<\s*lowcase\s*>/gi, '<L>');
    text = text.replace(/<\s*\/lowcase\s*>/gi, '</L>');
    text = text.replace(/<\s*mixcase\s*>/gi, '<M>');
    text = text.replace(/<\s*\/mixcase\s*>/gi, '</M>');

    return text;
}

function parseTags(text){
    var result = [],
        inputArr = text.split(''),
        tags = [],
        inTag = false,
        inClosingTag = false;

    for(var i = 0; i < inputArr.length; i++){
        if(inputArr[i] === '<'){
            inTag = true;
            continue;
        }

        if(inputArr[i] === '/' && inTag){
            inClosingTag = true;
            continue;
        }

        if(inTag && !inClosingTag && inputArr[i].match(/[a-z]/i)){
            tags.push(inputArr[i]);
            continue;
        }

        if(inputArr[i] === '>'){
            if(inClosingTag){
                tags.pop();
                inClosingTag = false;
            }
            inTag = false;
            continue;
        }

        if(!inTag){
            if(!tags.length){
                result.push(inputArr[i]);
            }
            else{
                switch (tags[0]){
                    case 'L':
                        result.push(inputArr[i].toLowerCase());
                        break;
                    case 'U':
                        result.push(inputArr[i].toUpperCase());
                        break;
                    case 'M':
                        if (!Math.round(Math.random())) {
                            result.push(inputArr[i].toLowerCase());
                        } else {
                            result.push(inputArr[i].toUpperCase());
                        }
                        break;
                }
            }
        }
    }

    return result.join('');
}

