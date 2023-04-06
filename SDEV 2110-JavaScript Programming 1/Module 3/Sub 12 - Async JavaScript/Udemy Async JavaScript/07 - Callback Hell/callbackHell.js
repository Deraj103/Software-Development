//"callback hell", nesting callback within callback within callback and so on.
const getTodos = (resource, callback) => {
    const request = new XMLHttpRequest();

    request.addEventListener('readystatechange', () => {
        if(request.readyState === 4 && request.status === 200){
            //JSON stands for JavaScript Object Notation
            const data = JSON.parse(request.responseText)
            callback(undefined, data);
        } else if (request.readyState === 4){
            callback('could not fetch data', undefined);
        };
    });
    request.open('GET', resource);
    request.send();
};

getTodos('todos/jared.json', (err, data) => {
    console.log(data);
    getTodos('todos/tina.json', (err, data) => {
        console.log(data);
        getTodos('todos/kid.json', (err, data) => {
            console.log(data);
        });
    });
});