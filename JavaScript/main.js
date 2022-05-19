let inputElement = document.getElementById('input');
let adicionarElement = document.getElementById('botao');
let listElement = document.getElementById('lista');
let removerElement = document.getElementById('botao1');


function addItem() {
    let getText = inputElement.value;
    let textItem = document.createTextNode(getText);
    let liElement = document.createElement('li');
    let aElement = document.createElement('a');

    listElement.appendChild(liElement);
    liElement.appendChild(textItem);
}

function removerItem() {
    listElement.firstChild.remove();
}


adicionarElement.onclick = function() {
    addItem();
    inputElement.value = '';
}

removerElement.onclick = function() {
    removerItem();
}