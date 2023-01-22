document.onload = () => {
    let Theme = window.localStorage.getItem("Theme");
    console.log(Theme);
    var app = document.getElementById('#app');
    if (Theme == 'Light') {
        app.style.backgroundColor = 'white';
    }
    else {
        app.style.backgroundColor = 'black';
    }
};
window.getElementWidth = (element) => {
    return element.offsetWidth;
};

//export
function showPrompt(message) {
    return prompt(message, "type here");
}

function ToggleSidebar(toggleValue) {
    var element = document.querySelector('.sidebar');
    if (toggleValue == true) {
        element.removeAttribute('style');
    }
    else {
        element.setAttribute('style', 'visibility: visible;');
    }
}

function ToggleTheme(theme) {
    console.log(theme);
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