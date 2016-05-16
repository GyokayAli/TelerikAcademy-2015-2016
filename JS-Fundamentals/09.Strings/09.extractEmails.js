/**
 * Problem 9. Extract e-mails
 * Write a function for extracting all email addresses from given text.
 * All sub-strings that match the format @… should be recognized as emails.
 * Return the emails as array of strings.
 */

var emailTxt = 'Email examples example@abv.bg or liberty042@mail.ru, or example@yahoo.com,meff_dont_stay@mail.ru, japaneseeyes@mail.ru, chebr007@mail.ru, golowcko@mail.ru, vk20106@mail.ru';

function getEmails(text){
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

console.log(getEmails(emailTxt).join('\n\r'));
