const form = document.querySelector('.signup-form');
const idFeedback = document.querySelector('.idFeedback');
const firstNameFeedback = document.querySelector('.firstNameFeedback');
const lastNameFeedback = document.querySelector('.lastNameFeedback');

form.addEventListener('submit', e => {
    e.preventDefault();

    const id = form.identification.value;
    const idPattern = /^[0-9]{10,10}$/;

    //Form validation
    if(idPattern.test(id)){
        //Feedback good info.
        idFeedback.textContent = 'ID: entry valid.';
        form.identification.setAttribute('class', 'success');
    } else {
        //Feedback bad info.
        idFeedback.textContent = 'ID Must be 10 digits in length.';
        form.identification.setAttribute('class', 'error');
    }

    const firstName = form.firstName.value;
    const firstNamePattern = /^[a-zA-Z]{2,}$/;

    if(firstNamePattern.test(firstName)){
        firstNameFeedback.textContent = 'First Name: entry valid.';
        form.firstName.setAttribute('class', 'success');
    } else {
        firstNameFeedback.textContent = 'First name Must be at least two letters in length.';
        form.firstName.setAttribute('class', 'error');
    }

    const lastName = form.lastName.value;
    const lastNamePattern = /^[a-zA-Z]{2,}$/;

    if(lastNamePattern.test(lastName)){
        lastNameFeedback.textContent = 'Last Name: entry valid.';
        form.lastName.setAttribute('class', 'success');
    } else {
        lastNameFeedback.textContent = 'Last name Must be at least two letters in length.';
        form.lastName.setAttribute('class', 'error');
    }
});