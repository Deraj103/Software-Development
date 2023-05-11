//rest parameter
const double = (...nums) => {
    console.log(nums);
    return nums.map(num => num*2);
}

const result = double(1,3,5,7,9,2,4,6,8);
console.log(result)

//spread syntax (arrays). Opposite to rest parameter
const people = ['jacob', 'shauna', 'harold'];
console.log(...people);
// the '...people' combines what is within the members array into the people array.
const members = ['jane', 'holly', ...people];
console.log(members);

//spread syntax (objects)
const person = { name: 'shaun', age: 30, job: 'net ninja' };
console.log(person);

const personClone = {...person, location: 'manchester'};
console.log(personClone);