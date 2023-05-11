// sets. Any given set, a certain value can only be present once. Sets are a bit like arrays but they do not allow duplicates.
const namesArray = ['Dova', 'Billy-Bob', 'Dova', 'Jax'];
console.log(namesArray);

const namesSet = new Set(['Dova', 'Billy-Bob', 'Dova', 'Jax']);
// notice that any duplicates are deleted
console.log(namesSet);

// passing an array into a set still gives the same results of deleting any duplicate values.
const namesSet2 = new Set(namesArray);
console.log(namesSet2);

const uniqueNames = [...namesSet];
console.log(uniqueNames);

// we can do this in a single line.
const uniqueNames2 = [... new Set(namesArray)];
console.log(uniqueNames2);

// how to add to sets
const ages = new Set();
ages.add(20);
//chaining add methods
ages.add(25).add(30);
// how to remove values from sets
ages.delete(20);

// how to check for certain values in sets
console.log(ages, ages.size);
console.log(ages.has(30), ages.has(20));

// how to clear sets.
ages.clear();
console.log(ages);

// how to cycle through sets
const ninjas = new Set([
    {name: 'shaun', age: 30},
    {name: 'crystal', age: 29},
    {name: 'chang', age: 32}
]);

ninjas.forEach(ninja => {
    console.log(ninja.name, ninja.age);
});