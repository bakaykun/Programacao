/*
	Craindo as variaveis para poder manipular os elementos HTML
*/

let inputElement = document.getElementById('input');
let buttonElement = document.getElementById('botao');
let listElement = document.getElementById('lista');

/* A função para criar os itens da lista*/

function addItem(){
	let getText = inputElement.value;
	let textItem = document.createElement(getText);
	let liElement = document.createElement('li');

	listElement.appendChild
}