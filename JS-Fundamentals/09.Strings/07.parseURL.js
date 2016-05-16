/**
 * Problem 7. Parse URL
 * Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 * Return the elements in a JSON object.
 */

function parseURL(str) {
    var	o   = parseURL.options,
        m   = o.parser[o.strictMode ? "strict" : "loose"].exec(str),
        url = {},
        i   = 14;

    while (i--) url[o.key[i]] = m[i] || "";

    url[o.q.name] = {};
    url[o.key[12]].replace(o.q.parser, function ($0, $1, $2) {
        if ($1) url[o.q.name][$1] = $2;
    });

    return url;
};

parseURL.options = {
    strictMode: false,
    key: ["source","protocol","authority","userInfo","user","password","host","port","relative","path","directory","file","query","anchor"],
    q:   {
        name:   "queryKey",
        parser: /(?:^|&)([^&=]*)=?([^&]*)/g
    },
    parser: {
        strict: /^(?:([^:\/?#]+):)?(?:\/\/((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?))?((((?:[^?#\/]*\/)*)([^?#]*))(?:\?([^#]*))?(?:#(.*))?)/,
        loose:  /^(?:(?![^:@]+:[^:@\/]*@)([^:\/?#.]+):)?(?:\/\/)?((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?)(((\/(?:[^?#](?![^?#\/]*\.[^?#\/.]+(?:[?#]|$)))*\/?)?([^?#\/]*))(?:\?([^#]*))?(?:#(.*))?)/
    }
};

var url = parseURL('http://telerikacademy.com/Courses/Courses/Details/239');
var parsed = {
    protocol: url.protocol,
    server: url.host,
    resource: url.path};

console.log(parsed);