const commMethod = 'letter';

let user = {
    custID: '123456',
    name: 'Josh Clark',
    address: '100 South 200 North, Austin, TX 85000',
    phone: '801-654-1122',
    email: 'jman123@gmail.com',
    contactInfoIntro: function(){
        console.log(`Contact info for customer ${this.custID}, ${this.name}`);
    },
    sendEmail: function(){
        console.log(`Send email to the customer at ${this.email}`);
    },
    callPhone: function(){
        console.log(`Call the customer at ${this.phone}`)
    },
    textPhone: function(){
        console.log(`Text the customer at ${this.phone}`)
    },
    sendLetter: function(){
        console.log(`Send a letter to the customer at ${this.address}`)
    },

};

user.contactInfoIntro();

switch(commMethod){
    case 'email':
        user.sendEmail();
        break;
    case 'call':
        user.callPhone();
        break;
    case 'text':
        user.textPhone();
        break;
    case 'letter':
        user.sendLetter();
        break;
    default:
        console.log('Not a valid communication method.')
};