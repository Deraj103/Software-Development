//constructor function
class User {
    constructor(username, email){
        //set up properties
        this.username = username;
        this.email = email;
        this.score = 0;
    }
    login(){
        console.log(`${this.username} just logged in`);
        return this;
    }
    logout(){
        console.log(`${this.username} just logged out`)
        return this;
    }
    incScore(){
        this.score += 1
        console.log(`${this.username} has a score of ${this.score}`);
        return this;
    }
}

class Admin extends User{
    constructor(username, email, title){
        super(username, email)
        this.title = title;
    }
    deleteUser(user){
        users = users.filter(u => u.username !== user.username);
    }
}

const userOne = new User('jared', 'jt@gmail.com');
const userTwo = new User('Valentina', 'vt@gmail.com');
const userThree = new Admin('isaac', 'it@gmail.com', 'super-nerd');

console.log(userOne, userTwo, userThree);

userOne.logout().incScore().incScore().logout();

let users = [userOne, userTwo, userThree];
console.log(users);

userThree.deleteUser(userTwo);
console.log(users);

//the 'new' keyword
//1 - it creates a new empty object {}
//2 - it binds the value of 'this' to the new empty object
//3 - it calls the constructor function to 'build' the object