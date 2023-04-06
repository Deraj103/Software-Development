const newEmployee = ['Larry Gordon 25864', 'Jared Tims 25874', 'Holly Anderson 25968', 'Bill Hansen 25879', 'Tommy Landon 12365']

function splitInfo(employee){
    let convertedEmp = newEmployee.toString();
    console.log('Generating email addresses...')
    console.log(`Data to process: ${employee}`)
//Finds position of first space.
    firstSpace = employee.indexOf(' ');
//Finds positions of last space.
    lastSpace = employee.lastIndexOf(' ');
//Slices out first name.
    firstName = employee.slice(0,firstSpace);
//Changes first name to all lowercase.
    firstNameLower = firstName.toLowerCase();
//Slices out employee ID.
    empID = employee.slice(lastSpace+1,employee.length);
//Slices out last name.
    lastName = employee.slice(firstSpace+1,lastSpace);
//Changes last name to all lowercase
    lastNameLower = lastName.toLowerCase();
    console.log(`Fetching Data: first name: ${firstName}, last name: ${lastName}, ID: ${empID}`);
}

function spliceInfo(){
//First letter of first name
    firstNameLetter = firstNameLower.slice(0,1);
//First 7 letters of last name. If less than 7 letters than use entire last name.
    lastNameLetters = lastNameLower.slice(0,7)
//Last two digits of empID.
    firstofEmpID = empID.slice(0,2)
//Put all together in the following order: 7 letters or whole of last, first letter of first, last two of empID, and '@company.com.
    console.log(`Chop it: first name letter: ${firstNameLetter}, last name: ${lastNameLower}, ID digits: ${firstofEmpID}`);
    console.log(`Email: ${lastNameLetters}${firstNameLetter}${firstofEmpID}@company.com`);
    console.log('');
}

function combinedFunctions(employee){
    splitInfo(employee);
    spliceInfo();
}

function finalResult(myCallBackFunc){
    newEmployee.forEach((employee) => {
        myCallBackFunc(employee);
    });
}

finalResult(combinedFunctions);