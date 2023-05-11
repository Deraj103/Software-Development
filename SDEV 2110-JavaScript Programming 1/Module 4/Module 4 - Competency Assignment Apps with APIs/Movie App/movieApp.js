const form = document.querySelector('form');
const titleInput = document.querySelector('.input');
const title = document.querySelector('.title');
const year = document.querySelector('.year');
const plot = document.querySelector('.plot');
const actors = document.querySelector('.actors');
const movieInfo = document.querySelector('.movieInfo');


//example api request: http://www.omdbapi.com/?i=tt3896198&apikey=7282c428

async function getMovieInfo() {
    const key = '7282c428';
    const response = await fetch(`https://www.omdbapi.com/?t=${titleInput.value}&apikey=${key}`);
    const result = await response.json();

    return result;
}

const updateUI = (data) => {
    console.log(data);

    title.innerHTML = `
    <div class="title h2 text-primary">${data.Title}</div>
    `;

    year.innerHTML = `
    <div class="year h4">Year: ${data.Year}</div>
    `;

    plot.innerHTML = `
    <div class="fw-bold">${data.Plot}</div>
    `;

    actors.innerHTML = `
    <div class="fw-bold"> ${data.Actors}</div>
    `;

};

form.addEventListener('submit', e => {
    e.preventDefault();

    const result = form.result;

    getMovieInfo(result)
        .then(data => updateUI(data))
        .catch(err => console.log(err))
});