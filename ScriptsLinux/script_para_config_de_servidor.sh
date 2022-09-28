#!/bin/bash

mkdir /publico
mkdir /adm
mkdir /ven
mkdir /sec

groupadd GRP_ADM
groupadd GRP_VEN
groupadd GRP_SEC

useradd carlos -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd maria -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd joao -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd debora -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd sebastiana -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd roberto -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd josefina -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd amanda -s /bin/bash -m -p $(openssl passwd -crypt Senha123)
useradd rogerio -s /bin/bash -m -p $(openssl passwd -crypt Senha123)

usermod  carlos,maria,joao -G GRP_ADM
usermod  debora,sebastiana,roberto -G GRP_VEN
usermod  jsefina,amanda,rogerio -G GRP_SEC





