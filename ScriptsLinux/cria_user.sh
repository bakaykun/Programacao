#!/bin/bash


echo "Criando Usuários do SiSTEMA"

useradd guest10 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest11 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest20 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest30 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest40 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest50 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

useradd guest60 -c "Uusário convidado da aula" -s /bin/bash -m -p 123
passwd  guest -e

echo "Finalizado!!"
