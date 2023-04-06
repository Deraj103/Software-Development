/* Color options to choose from:
    1)blue
    2)red
    3)yellow */

const colorSelection1 = 'yellow'
const colorSelection2 = 'blue'

const result1 = 'purple'
const result2 = 'green'
const result3 = 'orange'

console.log('IF Structure');
if(colorSelection1 === 'blue' && colorSelection2 === 'red' || colorSelection1 === 'red' && colorSelection2 === "blue"){
    console.log('first color is ' + colorSelection1 + ', ' + 'second color is ' + colorSelection2);
    console.log('new color is ' + result1);
} else if (colorSelection1 === 'blue' && colorSelection2 === 'yellow' || colorSelection1 === 'yellow' && colorSelection2 === "blue"){
    console.log('first color is ' + colorSelection1 + ', ' + 'second color is ' + colorSelection2);
    console.log('new color is ' + result2);
} else if (colorSelection1 === 'yellow' && colorSelection2 === 'red' || colorSelection1 === 'red' && colorSelection2 === "yellow"){
    console.log('first color is ' + colorSelection1 + ', ' + 'second color is ' + colorSelection2);
    console.log('new color is ' + result3);
} else (console.log('Not a valid color option.'));


/* Weather options to choose from:
    1)ice
    2)snow
    3)rain
    4)sun */

const weather = 'sun'

console.log('Switch Structure')
switch(weather){
    case 'ice':
        console.log('Weather is ' + weather);
        console.log('Use studded tires and chains.');
        break;
    case 'snow':
        console.log('Weather is ' + weather);
        console.log('Brush all snow off the car before driving.');
        break;
    case 'rain':
        console.log('Weather is ' + weather);
        console.log('Turn on headlights and use wipers.');
        break;
    case 'sun':
        console.log('Weather is ' + weather);
        console.log('Wear sunglasses.');
        break;
    default:
        console.log('Weather is ' + weather);
        console.log('Not a valid weather condition');
}