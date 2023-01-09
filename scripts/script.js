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

window.jsReturnArray = () => {
    DotNet.invokeMethodAsync('BoxOfficeDemo.Client', 'ReturnArray')
        .then(data => {
            console.log(data)
        });
};

window.sayMessage = (dotNetHelper) => {
    return dotNetHelper.invokeMethodAsync("GetMessage");
}