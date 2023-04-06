lightBulb.addEventListener('mouseover', e => {
    e.preventDefault();
    lightBulb.src = "light_bulb_on.png";
});

lightBulb.addEventListener('mouseout', e => {
    e.preventDefault();
    lightBulb.src = "light_bulb_off.png";
});

pumpkin.addEventListener('click', e => {
    e.preventDefault();
    if (pumpkin.getAttribute('src') === "pumpkins.jpg"){
    pumpkin.src = 'pumpkins-lit.jpg';
    } else {
    pumpkin.src = "pumpkins.jpg";
}
});