//async and await
//async is any function that delivers its result asynchronously. It will not block the rest of the code - always returns a promise.
//await stalls javascript code until a promise has been fulfilled.

const getTodos = async () => {

    const response = await fetch('todos/jared.json');

    if(response.status !== 200){
        throw new Error('cannot fetch data');
    }

    const data = await response.json();
    return data;

};

getTodos()
    .then(data => console.log('resolved:', data))
    .catch(err => console.log('rejected:', err.message));

// //fetch API. 3 steps: 1) fetch the data. 2)take the response and return a promise. 3)catch any errors at the end.
// //step 1
// fetch('todos/jared.json').then((response) => {
//     console.log('resolved', response);
// //step 2
//     return response.json();
// }).then(data => {
//     console.log(data);
// //step 3
// }).catch((err) => {
//     console.log('rejected', err);
// });