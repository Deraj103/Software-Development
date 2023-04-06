console.log(1);
console.log(2);

//asyncronis code = start something to finish it later.
//asyncronis code does not block the rest of the code form firing. The bottom example will wait for two seconds than display.
setTimeout(() => {
    console.log('callback function fired');
}, 2000);

console.log(3);
console.log(4);