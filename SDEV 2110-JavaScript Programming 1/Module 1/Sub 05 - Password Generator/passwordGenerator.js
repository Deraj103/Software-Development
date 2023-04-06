const upperCase = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];
const lowerCase = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'];
const numbers = ['1','2','3','4','5','6','7','8','9'];
const symbols = ['!','@','#','$','%','^','&','*','(',')','_','+','-','='];
let newCharacter = '';
let newPassword = '';

//Randomizes the number that will select which array will be chosen in the for loop.
function arraySelector(){
    const random = Math.random();
    const arrayNumber = Math.floor(random * 4);
    return arrayNumber
}

//Randomizes which character in the upperCase array that will be chosen.
function upperCaseSelector(){
    const random = Math.random();
    const characterSelector = Math.floor(random * upperCase.length)
    return characterSelector
}

//Randomizes which character in the lowerCase array that will be chosen.
function lowerCaseSelector(){
    const random = Math.random();
    const characterSelector = Math.floor(random * lowerCase.length)
    return characterSelector
}

//Randomizes which character in the numbers array that will be chosen.
function numberSelector(){
    const random = Math.random();
    const characterSelector = Math.floor(random * numbers.length)
    return characterSelector
}

//Randomizes which character in the symbols array that will be chosen.
function symbolSelector(){
    const random = Math.random();
    const characterSelector = Math.floor(random * symbols.length)
    return characterSelector
}

//The for loop will loop 12 times to create a password length of 12 characters.
//At each iteration, it will add the randomized characters derived from the four arrays.
for(let i = 0; i < 12; i++){
    switch(arraySelector()){
        case 0:
            newPassword += upperCase[upperCaseSelector()];
            break;
        case 1:
            newPassword += lowerCase[lowerCaseSelector()];
            break;
        case 2:
            newPassword += numbers[numberSelector()];
            break;
        case 3:
            newPassword += symbols[symbolSelector()];
            break;
        default:
    };
};

console.log(`New Password = ${newPassword}`);