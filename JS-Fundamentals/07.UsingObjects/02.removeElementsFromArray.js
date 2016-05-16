/**
 * Created by Admin on 5.6.2015 ã..
 */
var arr =  [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

Array.prototype.remove = function(array, element){
    for (var i = 0; i < array.length; i++) {
        if (array[i] === element) {
            array.splice(i, 1);
            i-=1;
        }
    }
}

// test
console.log(arr);
arr.remove(arr,1);
console.log(arr);