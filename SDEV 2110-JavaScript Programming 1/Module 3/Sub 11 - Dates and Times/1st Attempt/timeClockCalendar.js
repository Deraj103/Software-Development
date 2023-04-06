const militaryTime = document.getElementById('militaryTime');
const standardTime = document.getElementById('standardTime');

const milClock = () => {
    
    const now = new Date();

    const h = now.getHours();
    const m = now.getMinutes();
    const s = now.getSeconds();

    const displayMilTime = `
    Military Time: 
    <span>${h}</span> :
    <span>${m}</span> :
    <span>${s}</span>
    `;

    militaryTime.innerHTML = displayMilTime;
};

setInterval(milClock, 1000);

const standClock = () => {

    const now = new Date();

    const h = dateFns.format(now, 'h');
    const m = dateFns.format(now, 'm');
    const s = dateFns.format(now, 's A');

    const displayStandTime = `
    Standard Time:
    <span>${h}</span> :
    <span>${m}</span> :
    <span>${s}</span>
    `;

    standardTime.innerHTML = displayStandTime;
};

setInterval(standClock, 1000);

const longDateClock = () => {

    const now = new Date();

    const date = dateFns.format(now, 'MMMM E, YYYY');

    const displayLongDate = `
    Long Date:
    <span>${date}</span>
    `;

    longDate.innerHTML = displayLongDate;
};

setInterval(longDateClock, 1000);

const milDateClock = () => {
    const now = new Date();

    const date = dateFns.format(now, 'E MMM YYYY');

    const displayMilDate = `
    Military Date:
    <span>${date}</span>
    `;

    milDate.innerHTML = displayMilDate;
};

setInterval(milDateClock, 1000);

const slashDateClock = () => {

    const now = new Date();

    const day = dateFns.format(now, 'D');
    const month = dateFns.format(now, 'M');
    const year = dateFns.format(now, 'YY');

    const displaySlashDate = `
    Slash Date:
    <span>${month}</span> /
    <span>${day}</span> /
    <span>${year}</span>
    `;

    slashDate.innerHTML = displaySlashDate;
};

setInterval(slashDateClock, 1000);

const euroDateClock = () => {

    const now = new Date();

    const month = dateFns.format(now, 'M');
    const day = dateFns.format(now, 'D');
    const year = dateFns.format(now, 'YYYY');

    const displayEuroDate = `
    Euro Date:
    <span>${month}</span> /
    <span>${day}</span> /
    <span>${year}</span>
    `;

    euroDate.innerHTML = displayEuroDate;
};

setInterval(euroDateClock, 1000);