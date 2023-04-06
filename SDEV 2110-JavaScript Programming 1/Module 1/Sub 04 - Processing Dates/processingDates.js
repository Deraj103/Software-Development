let originalDate = '5/3/2023'
let monthName = ['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sep','Oct','Nov','Dec'];

console.log('original date ' + originalDate);

let slash1 = originalDate.indexOf('/');
let slash2 = originalDate.lastIndexOf('/');

// console.log(slash1, slash2);

let MM = originalDate.slice(0,slash1);
let DD = originalDate.slice(slash1+1,slash2);
let YY = originalDate.slice(slash2+1,originalDate.length);
console.log('MM = ' + MM, 'DD = ' + DD, 'YY = ' + YY);

function standard(){
    console.log('standard format: ' + monthName[MM-1] + ' ' + DD + ', ' + YY)
}

function european(){
    console.log('european format: ' + DD + '/' + MM + '/' + YY)
}

function military(){
    console.log('military format: ' + DD + ' ' + monthName[MM-1] + ' ' + YY)
}

// console.log(MM + '/' + DD + '/' + YY);

standard();

european();

military();