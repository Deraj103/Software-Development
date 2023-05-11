const cityForm = document.querySelector('form');
const card = document.querySelector('.card');
const details = document.querySelector('.details');
const time = document.querySelector('img.time');
const icon = document.querySelector('.icon img');
const forecast = new Forecast();

const updateUI = (data) => {

    console.log(data);

    const { cityDets, weather } = data;

    const iconSrc = `img/weatherIcons/${weather.WeatherIcon}.png`;
    icon.setAttribute('src', iconSrc);

    let timeSrc = weather.IsDayTime ? 'img/day.webp' : 'img/night.webp';
    time.setAttribute('src', timeSrc);

    details.innerHTML = `
        <h5 class="my-3">${cityDets.EnglishName}</h5>
        <div class="my-3">${weather.WeatherText}</div>
        <br>
        <div class="temp my-4">
        <div class="icon bg-light mx-auto text-center">
            <span><img src="${iconSrc}" alt=""></span>
        </div>
            <span>${weather.Temperature.Imperial.Value}&deg;F =</span> 
            <span>${weather.Temperature.Metric.Value}&deg;C</span>
        </div>
    `;

    if (card.classList.contains('d-none')) {
        card.classList.remove('d-none');
    };
};

cityForm.addEventListener('submit', e => {
    e.preventDefault();

    const city = cityForm.city.value.trim();
    cityForm.reset();

    forecast.updateCity(city)
        .then(data => updateUI(data))
        .catch(err => console.log(err));

    //set local storage
    localStorage.setItem('city', city);

});

if(localStorage.getItem('city')){
    forecast.updateCity(localStorage.getItem('city'))
    .then(data => updateUI(data))
    .catch(err => console.log(err))
};