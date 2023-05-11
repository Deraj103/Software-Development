// part one
console.log('\nNumbers and Averages');

function numsAndAvs(...scores) {
    console.log(scores);

    let counter = 0;
    let total = 0;
    let average = 0;

    scores.forEach(score => {
        counter += 1;
        total += score;
        average = total / counter;
    });

    console.log(`There are ${counter} numbers which total ${total}`);
    console.log(`The average of those numbers are ${average}`);
}

numsAndAvs(1, 3, 5, 7, 8, 9, 11, 13);
numsAndAvs(23.5, 54.6, 86.4, 34.6, 32.4, 74.3);


// part two
function confSessions() {
    const session1 = [
        'Ann Adams', 'Ann Smith', 'Ben Benson',
        'Carl Cards', 'Daniel Dern', 'Emma Ernest',
        'Frank Forrest', 'Jared Tims'
    ];

    const session2 = [
        'Ann Adams', 'Jared Tims', 'Harry Heber',
        'Carl Cards', 'Emma Ernest', 'Jack Jones',
        'Mary Marks', 'Ann Smith', ...session1
    ];
    console.log('\nSession Attendees');
    console.log(`Number of attendees at session 1: ${session1.length}`);
    console.log(`Number of attendees at session 2: ${session2.length}`);

    console.log('\nCombine Sessions')
    console.log(session2);
    console.log(`Number of attendees at both sessions: ${session2.length}`)

    session2.forEach(attendee => {
        console.log(attendee);
    })

    console.log('\nRemove duplicate attendees.')
    const removeDuplicates = new Set(session2);
    console.log(removeDuplicates);

    removeDuplicates.forEach(attendee => {
        console.log(attendee);
    })

}

confSessions();