const tipForm = document.querySelector('.tipForm');
const nameFeedback = document.querySelector('.nameFeedback');
const passwordFeedback = document.querySelector('.passwordFeedback');
const mealCostFeedback = document.querySelector('.mealCostFeedback');

tipForm.addEventListener('submit', e => {
    e.preventDefault();

    let name = tipForm.name.value;
    const namePattern = /^[a-zA-Z\s]{4,}$/;

    if(namePattern.test(name)){
        nameFeedback.textContent = '';
        tipForm.name.setAttribute('class', 'success');
    } else {
        nameFeedback.textContent = 'Name must be at least 4 letters, no numbers.';
        tipForm.name.setAttribute('class', 'error');
    }

    let password = tipForm.password.value;
    const passwordPattern = /^.{12,12}$/;

    if(passwordPattern.test(password)){
        passwordFeedback.textContent = '';
        tipForm.password.setAttribute('class', 'success');
    } else {
        passwordFeedback.textContent = 'Password must be 12 characters, letters and numbers only.';
        tipForm.password.setAttribute('class', 'error');
    }

    let mealCost = tipForm.mealCost.value;
    mealCost = parseFloat(mealCost);
    const mealCostPattern = /^[0-9\.]{1,}$/

    if(mealCost <= 0){
        mealCostFeedback.textContent = 'Meal Cost must be more than $0';
        tipForm.mealCost.setAttribute('class', 'error');
        mealCostTotal.textContent = "";
        tipFeedback.textContent = "";
        totalFeedback.textContent = "";
        
    } else  if(mealCostPattern.test(mealCost)){
        mealCostFeedback.textContent = '';
        tipForm.mealCost.setAttribute('class', 'success');

        let moneyFormat = new Intl.NumberFormat('en-US', {
            style: 'currency',
            currency: 'USD'
        });

        let tip = tipForm.quality.value/100;
        tip = tip*mealCost;
        totalMealCost = mealCost+tip;
        let formattedMealCost = moneyFormat.format(mealCost);
        let formattedTip = moneyFormat.format(tip);
        let formattedTotal = moneyFormat.format(totalMealCost);
        console.log(`money formatter: tip: ${formattedTip}, total: ${formattedTotal}`);
        mealCostTotal.textContent = `Meal Cost: ${formattedMealCost}`;
        tipFeedback.textContent = `Tip: ${formattedTip}`;
        totalFeedback.textContent = `Total: ${formattedTotal}`;

    } else {
        mealCostFeedback.textContent = 'Meal Cost must be numbers and decimal only.';
        tipForm.mealCost.setAttribute('class', 'error');
        mealCostTotal.textContent = "";
        tipFeedback.textContent = "";
        totalFeedback.textContent = "";
    }
});