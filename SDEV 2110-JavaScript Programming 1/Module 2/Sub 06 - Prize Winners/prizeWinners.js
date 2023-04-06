const people = ['Jared Tims', 'Robert Hansen', 'Holly Anderson', 'Eric Jacobson', 'Herold Bigaloo',
    'Josh Patterson', 'Amy Jones', 'Mandy Jorgensen', 'Ashley Freleng', 'Zackarias Blythe'];
const prizes = ['55" OLED TV', 'iPad Pro', 'Home GYM Set', 'Home Computer', 'Hang Glider'];
const peopleList = document.getElementById('peopleList');
const prizeList = document.getElementById('prizeList');
const peopleWinner = document.getElementById('peopleWinner');
const prizeWinner = document.getElementById('prizeWinner');
let winner = '';
let prizeWon = '';

//For each winner, this forEach inserts a new line item directly into the html ul of id peopleList.
people.forEach(person => {
    peopleList.innerHTML += `<li>${person}`;
});

//For each prize, this forEach inserts a new line item directly into the html ul of id prizeList.
prizes.forEach(prize => {
    prizeList.innerHTML += `<li>${prize}`;
});

//Creates a random number to select from the winners array.
function randomWinner() {
    const random = Math.random();
    const winnerSelector = Math.floor(random * 10);
    const winner = people[winnerSelector];
    return winner
};

//Creates a random number to select from the prize array.
function randomPrize() {
    const random = Math.random();
    const prizeSelector = Math.floor(random * 5);
    const prizeWon = prizes[prizeSelector];
    return prizeWon
};

winner = randomWinner();

prizeWon = randomPrize();

peopleWinner.innerHTML = `${winner}!!!`;

prizeWinner.innerHTML = `${winner} will receive a ${prizeWon}!!!`;