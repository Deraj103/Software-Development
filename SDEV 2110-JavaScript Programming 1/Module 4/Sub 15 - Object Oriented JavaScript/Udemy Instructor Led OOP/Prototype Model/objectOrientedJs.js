//constructor function
function User(username, email){
    this.username = username;
    this.email = email;
}

User.prototype.login = function(){
    console.log(`${this.username} has logged in`)
    return this;
};

User.prototype.logout = function(){
    console.log(`${this.username} has logged out`)
    return this;
};

function Admin(username, email, title){
    User.call(this, username, email)
    this.title = title
}

Admin.prototype = Object.create(User.prototype);

Admin.prototype.deleteUser = function(){
    //delete user
};

const userOne = new User('jared', 'jt@gmail.com');
const userTwo = new User('Valentina', 'vt@gmail.com');
const userThree = new Admin('isaac', 'it@gmail.com', 'super-nerd');

console.log(userOne, userTwo, userThree);
userOne.login().logout();

//the 'new' keyword
//1 - it creates a new empty object {}
//2 - it binds the value of 'this' to the new empty object
//3 - it calls the constructor function to 'build' the object