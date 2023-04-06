console.log('For loop start');

let sum = 10
let j = 1
for(let i = 0; i < 5; i++){
    
    console.log('in loop:', j + sum + i);
    j=j+i+1;
}

console.log('For loop finished');

console.log('While loop start');

let i = 0;
let s = 1;
while(i < 5){
    
    console.log('in loop:', s + sum + i)
    i++;
    s=s+i;
}

console.log('While loop finished');