//fetch API. 3 steps: 1) fetch the data. 2)take the response and return a promise. 3)catch any errors at the end.
//step 1
fetch('todos/jared.json').then((response) => {
    console.log('resolved', response);
//step 2
    return response.json();
}).then(data => {
    console.log(data);
//step 3
}).catch((err) => {
    console.log('rejected', err);
});