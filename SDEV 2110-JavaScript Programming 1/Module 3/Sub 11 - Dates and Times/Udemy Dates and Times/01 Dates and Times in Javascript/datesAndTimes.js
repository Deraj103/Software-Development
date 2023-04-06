//Dates and Times
const now = new Date();

console.log(now);

//dates and times fall under the object category.
console.log(typeof now);

//year, months, day, times
//to get year.
console.log('getFullYear:', now.getFullYear());
//to get month. 
//JS is 0 based. Jan=0, Feb=1, Mar=2, Apr=3, and so on...
console.log('getMonth:', now.getMonth());
//gets day of the month.
console.log('getDate:', now.getDate());
//sunday=0, monday=1, tuesday=2, and so on...
console.log('getDay:', now.getDay());
//gets hour of the day in military time
console.log('getHours:', now.getHours());
//gets minute of the hour
console.log('getMinutes:', now.getMinutes());
//gets second of the minute
console.log('getSeconds:', now.getSeconds());

//timestamps
console.log('timestamp:', now.getTime());

//date strings
//gets day of week/month/day of month/year
console.log(now.toDateString());
//gets time of day in military time and time zone
console.log(now.toTimeString());
//gets month/day/year, time of day
console.log(now.toLocaleString());