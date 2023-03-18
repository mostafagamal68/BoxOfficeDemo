$(document).ready(function (){
    let Theme = window.localStorage.getItem("Theme");
    var html = document.querySelector('html');
    var body = document.querySelector('body');
    var app = document.querySelector('#app');
    if (Theme == '"Dark"') {
        html.classList.add('bg-dark');
        body.classList.add('bg-dark');
        app.classList.add('bg-dark');
    }
    else if (Theme == '"Amoled"') {
        html.classList.add('bg-black');
        body.classList.add('bg-black');
        app.classList.add('bg-black');
    }
    else {
        html.classList.add('bg-light');
        body.classList.add('bg-light');
        app.classList.add('bg-light');
    }
});

function ToggleBtn(element, toggle) {
    if (toggle) {
        element.setAttribute('disabled', 'disabled');
    }
    else {
        element.removeAttribute('disabled');
    }
}

window.getElementWidth = (element) => {
    return element.offsetWidth;
};

//export
function showPrompt(message) {
    return prompt(message, "type here");
}

function ToggleSidebar(toggleValue) {
    var element = document.querySelector('.sidebar');
    if (toggleValue == false) {
        element.removeAttribute('style');
    }
    else {
        element.setAttribute('style', 'visibility: visible;');
    }
}

function ToggleTheme(theme) {
    var page = document.querySelector('.page');
    var cards = document.querySelectorAll('.card');
    var controls = document.querySelectorAll('.form-control');
    if (theme == 'Light') {
        page.classList.remove('dark-mode');
        page.classList.remove('black-mode');
        cards.forEach(element => {
            element.classList.remove('bg-dark');
            element.classList.remove('bg-black');
            element.classList.remove('border-secondary');
        });
        controls.forEach(element => {
            element.classList.remove('bg-black');
            element.classList.remove('bg-dark');
            element.classList.remove('text-white');
        });
    }
    else if (theme == 'Dark') {
        page.classList.remove('black-mode');
        page.classList.add('dark-mode');
        cards.forEach(element => {
            element.classList.remove('bg-black');
            element.classList.add('bg-dark');
            element.classList.add('border-secondary');
        });
        controls.forEach(element => {
            element.classList.remove('bg-black');
            element.classList.add('bg-dark');
            element.classList.add('text-white');
        });
    }
    else if (theme == 'Amoled') {
        page.classList.remove('dark-mode');
        page.classList.add('black-mode');
        cards.forEach(element => {
            element.classList.remove('bg-dark');
            element.classList.add('bg-black');
            element.classList.add('border-secondary');
        });
        controls.forEach(element => {
            element.classList.remove('bg-dark');
            element.classList.add('bg-black');
            element.classList.add('text-white');
        });
    }
}

window.jsReturnArray = () => {
    DotNet.invokeMethodAsync('BoxOfficeDemo.Client', 'ReturnArray')
        .then(data => {
            console.log(data)
        });
};

window.sayMessage = (dotNetHelper) => {
    return dotNetHelper.invokeMethodAsync("GetMessage");
}