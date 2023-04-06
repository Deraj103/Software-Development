//request object
const request = new XMLHttpRequest();

//we dont know in our code when this is complete so we add an event listener with a specific event called ready state change.
//now when js is ran, it will have ready states: 
//1 OPENED - client has been created. open() not called yet.
//2 HEADERS_RECEIVED - send() has been called, and headers and status are available.
//3 LOADING - Downloading; responseText holds partial data.
//4 DONE - The operation is complete. Most crucial step since we can use the data at this point.
request.addEventListener('readystatechange', () => {
    //console.log(request, request.readyState);
    if(request.readyState === 4){
        console.log(request.responseText);
        //results would be a large string of json data.
    };
});
//the open method takes two arguments. 1st is a string (GET). 2nd is where we want to make the request to, 
//where do we want to get the data ('https://jsonplaceholder.typicode.com/todos/')?
//this does not send the request, it merely sets up the request.
request.open('GET', 'https://jsonplaceholder.typicode.com/todos/');
//the code below sends the request
//console log: network, todos/ 
request.send();