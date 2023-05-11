// the main feature of a symbol is that they are completely unique from each other. 
// No two symbols can equal each other, even IF they are identical in their values.
const symbolOne = Symbol('a generic name');
const symbolTwo = Symbol('a generic name');

console.log(symbolOne, symbolTwo, typeof symbolOne);
console.log(symbolOne === symbolTwo);

const ninja = {};

ninja.age = 30;
ninja['belt'] = 'orange';
ninja['belt'] = 'black'; // it overwrites the belt property.

console.log(ninja);

ninja[symbolOne] = 'ryu';
ninja[symbolTwo] = 'shaun';

console.log(ninja);