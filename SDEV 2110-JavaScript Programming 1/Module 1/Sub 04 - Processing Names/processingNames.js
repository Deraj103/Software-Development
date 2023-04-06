/*Assignment notes: I need to implement functions, arrays, forEach loops, 
callback functions, and string processing (see Section 2 for review). */

let fullName = ['Larry Gordon', 'Jared Tims', 'Holly Anderson', 'Bill Hansen']
let first = '';
let last = '';

//5th * amount of names in array
function nameSplit(name){
    let nameSplit = name.indexOf(' ');
    first = name.slice(0,nameSplit);
    last = name.slice(nameSplit+1,name.length);
    console.log(`Name being processed: ${name}`);
    console.log(`First name: ${first}, Last name: ${last}`);
}

//6th * amount of names in array
function reverseFunction(){
    let reverse = (`${last}, ${first}`);
    console.log(`Reversed Name: ${reverse}`);
}

//7th * amount of names in array
function greetingFunction(){
    let firstInitial = first.slice(0,1);
    let combinedNames = (`${firstInitial}. ${last}`);
    console.log(`Greeting: Dear ${combinedNames}`);
}

//4th * amount of names in array
function combinedFunctions(name){
    nameSplit(name); //5th
    reverseFunction(); //6th
    greetingFunction(); //7th
    console.log(''); //8th (final)
}

//2nd
function finalResult(myCallBackFunc){
    fullName.forEach((name) => {
        myCallBackFunc(name); //3rd * amount of names in array
    });
}

//1st
finalResult(combinedFunctions);