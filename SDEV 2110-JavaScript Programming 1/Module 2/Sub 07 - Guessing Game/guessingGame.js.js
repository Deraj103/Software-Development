let form = document.querySelector('.guess');
let results = document.querySelector('.results');
let previousGuesses = document.querySelector('.previousGuesses');
let resetButton = document.createElement('button');
let randomNumber = 0;
let turns = 0
const tooBig = 'WRONG, that guess was too BIG.'
const tooSmall = 'WRONG, that guess was too SMALL.'
const tooMany = '!!! Too many attempts, GAME OVER !!!'
const justRight = 'Congratulations! You got it right!'
const invalidResponse = 'Invalid number. Please select a number between 1-100.'

function generateRandomNumber(){
    randomNumber = Math.floor(Math.random() * 100) + 1;
    console.log(`Random Generated Number: ${randomNumber}`);
}

generateRandomNumber();


function calculateAnswer(){
    let userGuess = Number(guess.value);
    console.log(`User's guess: ${userGuess}`);
    if(turns > 9){
        results.textContent = tooMany
        results.setAttribute('class', 'tooMany');
        gameOver();
    } else if(userGuess > 100){
        turns += 1
        results.textContent = invalidResponse;
        results.setAttribute('class', 'invalid');
        previousGuesses.textContent += userGuess+ "  ";
    } else if(userGuess < randomNumber){
        turns += 1
        results.textContent = tooSmall;
        results.setAttribute('class', 'tooSmall');
        previousGuesses.textContent += userGuess+"  ";
    } else if(userGuess > randomNumber){
        turns += 1
        results.textContent = tooBig;
        results.setAttribute('class', 'tooBig');
        previousGuesses.textContent += userGuess+"  ";
    } else{
        userGuess === randomNumber
        results.textContent = justRight;
        results.setAttribute('class', 'justRight');
        gameOver();
    }
}

function gameOver(){
    guess.disabled = true;
    resetButton.textContent = 'Start new game.';
    resetButton.setAttribute('class', 'resetButton');
    document.body.appendChild(resetButton);
    resetButton.addEventListener('click', e => {
        e.preventDefault();
        resetButton.focus();
        form.parentNode.removeChild(resetButton);
        resetGame();
    });
}

function resetGame(){
    turns = 0
    results.textContent = null;
    previousGuesses.textContent = null;
    previousGuesses.innerHTML = "Previous guesses: ";
    guess.disabled = false;
    generateRandomNumber();
}

form.addEventListener('submit', e => {
    e.preventDefault();
    calculateAnswer();
    form.reset();
});