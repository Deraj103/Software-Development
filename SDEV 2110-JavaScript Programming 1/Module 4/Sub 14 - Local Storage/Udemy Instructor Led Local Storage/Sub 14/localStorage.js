// //Store data in local storage
// localStorage.setItem('name', 'jared');
// localStorage.setItem('age', 31);

// //Get data from local storage
// let name = localStorage.getItem('name');
// let age = localStorage.getItem('age');

// console.log(name, age);

// //Updating data
// localStorage.setItem('name', 'Valentina');
// //.notation
// localStorage.age = '30';

// name = localStorage.getItem('name');
// age = localStorage.getItem('age');
// console.log(name, age);

// //Deleting data from local storage
// localStorage.removeItem('name');

// //Remove all items from local storage
// localStorage.clear();

// name = localStorage.getItem('name');
// age = localStorage.getItem('age');

// console.log(name, age);


//Stringifying & Parsing Data
const todos = [
    {text: 'play DSP', author: 'jared'},
    {text: 'buy groceries', author: 'valentina'},
    {text: 'do homework', author: 'kids'}
];

// console.log(JSON.stringify(todos));
localStorage.setItem('todos', JSON.stringify(todos));

//How to convert it back into a string
const stored = localStorage.getItem('todos');

console.log(JSON.parse(stored));