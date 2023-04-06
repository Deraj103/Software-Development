// timestamps

const before = new Date('March 20 2023 8:42:00');
const now = new Date();

console.log(now.getTime(), before.getTime());

const diff = now.getTime() - before.getTime();
console.log(diff);

//the difference in minutes between the now and before dates
const mins = Math.round(diff / 1000 / 60);
//the difference in hours between the now and before dates
const hours = Math.round(mins / 60);
//the difference in days between the now and before dates
const days = Math.round(hours / 24);

console.log(mins, hours, days);

console.log(`the blog was written ${days} days ago.`);

//converting timestamps into date objects
const timestamp = 1675938474990;
console.log(new Date(timestamp));