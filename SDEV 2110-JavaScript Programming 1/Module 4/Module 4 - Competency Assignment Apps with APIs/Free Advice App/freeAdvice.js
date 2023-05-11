const form = document.querySelector('form');
const advice = document.querySelector('.advice');

async function getAdvice() {
    const response = await fetch('https://api.adviceslip.com/advice');
    const result = await response.json();
    console.log(result);
    advice.textContent = result.slip.advice;
}

form.addEventListener('click', e => {
    e.preventDefault();
    getAdvice();
});