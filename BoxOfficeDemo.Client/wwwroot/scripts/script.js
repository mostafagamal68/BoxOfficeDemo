window.getElementWidth = (element) => {
    return element.offsetWidth;
};

//export
function showPrompt(message) {
    return prompt(message, "type here");
}

function ToggleSidebar(elementValue) {
    console.log(elementValue);
    element = document.querySelector('.sidebar');
    element.style.visibility = elementValue;
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