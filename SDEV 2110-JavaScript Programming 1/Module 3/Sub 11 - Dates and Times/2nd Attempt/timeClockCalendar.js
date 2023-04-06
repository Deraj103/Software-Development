const milClock = () => {
    
    const now = new Date();

    const time = dateFns.format(now, 'HH:mm:ss')

    const displayMilTime = `
    Military Time: 
    <span>${time}</span>
    `;

    militaryTime.innerHTML = displayMilTime;
};

setInterval(milClock, 1000);

const standClock = () => {

    const now = new Date();

    const time = dateFns.format(now, 'h:m:s A')

    const displayStandTime = `
    Standard Time:
    <span>${time}</span>
    `;

    standardTime.innerHTML = displayStandTime;
};

setInterval(standClock, 1000);

const longDateClock = () => {

    const now = new Date();

    const date = dateFns.format(now, 'MMMM D, YYYY');

    const displayLongDate = `
    Long Date:
    <span>${date}</span>
    `;

    longDate.innerHTML = displayLongDate;
};

setInterval(longDateClock, 1000);

const milDateClock = () => {
    const now = new Date();

    const date = dateFns.format(now, 'D MMM YYYY');

    const displayMilDate = `
    Military Date:
    <span>${date}</span>
    `;

    milDate.innerHTML = displayMilDate;
};

setInterval(milDateClock, 1000);

const slashDateClock = () => {

    const now = new Date();

    const date = dateFns.format(now, 'M / D / YY')

    const displaySlashDate = `
    Slash Date:
    <span>${date}</span>
    `;

    slashDate.innerHTML = displaySlashDate;
};

setInterval(slashDateClock, 1000);

const euroDateClock = () => {

    const now = new Date();

    const date = dateFns.format(now, 'D / M / YYYY')

    const displayEuroDate = `
    Euro Date:
    <span>${date}</span>
    `;

    euroDate.innerHTML = displayEuroDate;
};

setInterval(euroDateClock, 1000);