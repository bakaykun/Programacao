#!/bin/bash
#Criando arquivo para mover tudo que tem com .sh
if cd /home/bakay/scripts
then
        sudo mv *.sh /home/bakay/scripts
else 
	mkdir /home/bakay/scripts
	sudo mv *.sh /home/bakay/scripts
fi


