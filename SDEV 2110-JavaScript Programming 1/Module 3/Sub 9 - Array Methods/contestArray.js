let coders = [
    {coder: 'Jared', score: 6.7, speed: 35},
    {coder: 'Mary', score: 7.6, speed: 65},
    {coder: 'Greg', score: 5.6, speed: 57},
    {coder: 'Jason', score: 4.5, speed: 30},
    {coder: 'Grace', score: 5.9, speed: 29},
    {coder: 'Jane', score: 3.7, speed: 35},
    {coder: 'Paul', score: 8.6, speed: 42},
    {coder: 'Lisa', score: 2.5, speed: 65},
    {coder: 'Kevin', score: 4.3, speed: 61},
    {coder: 'Sarah', score: 5.9, speed: 52},
]
let best = '';
let good = '';

//Displays to the console the coder's name, score, and speed.
function displayCoders(){
    console.log(`Programming Contest participants, array is ${coders.length}`);
    coders.forEach(person => {
        console.log(`${person.coder} scored ${person.score} in ${person.speed} minutes.`)
    });
    console.log('');
}

function bestCoders(){
    best = coders.filter(function (person) {
        if (person.score > 5.0 && person.speed < 60) {
            return person;
        }
    });

    console.log(`After filtering for BEST, array is ${best.length}`)
    best.forEach(person => {
        console.log(`${person.coder} scored ${person.score} in ${person.speed} minutes.`)
    });
    console.log('');
}

function bestSortedScore(){
    best = best.sort((a,b) => b.score - a.score);
    let goldWinner = best[0];
    let silverWinner = best[1];
    let bronzeWinner = best[2];
    console.log('Programming Contest, BEST, sorted by score:')
    console.log(`Style Gold goes to ${goldWinner.coder}, score of ${goldWinner.score}.`);
    console.log(`Style Silver goes to ${silverWinner.coder}, score of ${silverWinner.score}.`);
    console.log(`Style Bronze goes to ${bronzeWinner.coder}, score of ${bronzeWinner.score}.`);
    console.log('');
}

function bestSortedSpeed(){
    best = best.sort((a,b) => b.speed - a.speed);
    let goldWinner = best[0];
    let silverWinner = best[1];
    let bronzeWinner = best[2];
    console.log('Programming Contest, BEST, sorted by speed:');
    console.log(`Style Gold goes to ${goldWinner.coder}, speed of ${goldWinner.speed}.`);
    console.log(`Style Silver goes to ${silverWinner.coder}, speed of ${silverWinner.speed}.`);
    console.log(`Style Bronze goes to ${bronzeWinner.coder}, speed of ${bronzeWinner.speed}.`);
    console.log('');
}

function goodCoders(){
    good = coders.filter(function  (person) {
        if (person.score > 5.0 || person.speed < 60) {
            return person;
        }
    });
    
    console.log(`After filtering for GOOD, array is ${good.length}`);
    good.forEach(person => {
        console.log(`${person.coder} scored ${person.score} in ${person.speed} minutes.`)
    });
    console.log('');
}

function goodSortedScore(){
    good = good.sort((a,b) => b.score - a.score);
    let goldWinner = good[0];
    let silverWinner = good[1];
    let bronzeWinner = good[2];
    console.log('Programming Contest, GOOD, sorted by score:');
    console.log(`Style Gold goes to ${goldWinner.coder}, score of ${goldWinner.score}.`);
    console.log(`Style Silver goes to ${silverWinner.coder}, score of ${silverWinner.score}.`);
    console.log(`Style Bronze goes to ${bronzeWinner.coder}, score of ${bronzeWinner.score}.`)
    console.log('');
}

function goodSortedSpeed(){
    good = good.sort((a,b) => b.speed - a.speed);
    let goldWinner = good[0];
    let silverWinner = good[1];
    let bronzeWinner = good[2];
    console.log('Programming Contest, GOOD, sorted by speed:');
    console.log(`Style Gold goes to ${goldWinner.coder}, speed of ${goldWinner.speed}.`);
    console.log(`Style Silver goes to ${silverWinner.coder}, speed of ${silverWinner.speed}.`);
    console.log(`Style Bronze goes to ${bronzeWinner.coder}, speed of ${bronzeWinner.speed}.`);
}

displayCoders();
bestCoders();
goodCoders();
bestSortedScore();
bestSortedSpeed();
goodSortedScore();
goodSortedSpeed();

//Examples of working filters
// const goodScore = coders.filter(person => person.score > 5.0);
// console.log(goodScore);

// const goodSpeed = coders.filter(person => person.speed < 60);
// console.log(goodSpeed);

// best.sort ((a,b) => {
//     if(a.score > b.score){
//         return -1;
//     } else if (b.score > a.score) {
//         return 1;
//     } else {
//         return 0;
//     }
// });
// console.log(best);