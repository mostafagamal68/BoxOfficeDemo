var unfilledStars = document.querySelectorAll('.stars button span .bi-star');
var filledStars = document.querySelectorAll('.stars button span .bi-star-fill');
var star1 = document.querySelector('#firstStar');
var star2 = document.querySelector('#secondStar');
var star3 = document.querySelector('#thirdStar');
var star4 = document.querySelector('#fourthStar');
var star5 = document.querySelector('#fifthStar');

export function SetStars(number) {
    if (number == 1) {
        star1.classList.replace('bi-star', 'bi-star-fill');
        star2.classList.replace('bi-star-fill', 'bi-star');
        star3.classList.replace('bi-star-fill', 'bi-star');
        star4.classList.replace('bi-star-fill', 'bi-star');
        star5.classList.replace('bi-star-fill', 'bi-star');
    }
    if (number == 2) {
        star1.classList.replace('bi-star', 'bi-star-fill');
        star2.classList.replace('bi-star', 'bi-star-fill');
        star3.classList.replace('bi-star-fill', 'bi-star');
        star4.classList.replace('bi-star-fill', 'bi-star');
        star5.classList.replace('bi-star-fill', 'bi-star');
    }
    if (number == 3) {
        star1.classList.replace('bi-star', 'bi-star-fill');
        star2.classList.replace('bi-star', 'bi-star-fill');
        star3.classList.replace('bi-star', 'bi-star-fill');
        star4.classList.replace('bi-star-fill', 'bi-star');
        star5.classList.replace('bi-star-fill', 'bi-star');
    }
    if (number == 4) {
        star1.classList.replace('bi-star', 'bi-star-fill');
        star2.classList.replace('bi-star', 'bi-star-fill');
        star3.classList.replace('bi-star', 'bi-star-fill');
        star4.classList.replace('bi-star', 'bi-star-fill');
        star5.classList.replace('bi-star-fill', 'bi-star');
    }
    if (number == 5) {
        star1.classList.replace('bi-star', 'bi-star-fill');
        star2.classList.replace('bi-star', 'bi-star-fill');
        star3.classList.replace('bi-star', 'bi-star-fill');
        star4.classList.replace('bi-star', 'bi-star-fill');
        star5.classList.replace('bi-star', 'bi-star-fill');
    }
    //unfilledStars = document.querySelectorAll('.stars button span .bi-star');
    //filledStars = document.querySelectorAll('.stars button span .bi-star-fill');
}

export function getClicked() {
    this.classList.replace('bi-star', 'bi-star-fill');
}

export function offClicked() {
    this.classList.replace('bi-star-fill', 'bi-star');
}

filledStars.forEach(li => li.addEventListener('mouseover', getClicked));
filledStars.forEach(li => li.addEventListener('mouseout', offClicked));