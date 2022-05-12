/*
	Craindo as variaveis para poder manipular os elementos HTML
*/

let inputElement = document.getElementById('input');
let buttonElement = document.getElementById('botao');
let listElement = document.getElementById('lista');

/* A função para criar os itens da lista*/

function addItem(){
	let getText = inputElement.value;
	let textItem = document.createTextNode(getText);
	let liElement = document.createElement('li');
	let aElement = document.createElement('a');

	listElement.appendChild(liElement);
	liElement.appendChild(textItem);
}

/* ao clicar no botão a função addItem() é chamada para criar um novo item em tela,
em seguida limpamos o campo para digitarmos um novo item a ser inserido*/

buttonElement.onclick = function () {
	addItem();
	inputElement.value = '';
}