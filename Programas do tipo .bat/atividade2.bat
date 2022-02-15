echo off
cls
echo ------------------------Mudando de cor------------------------------------------
color 10
echo.
echo.
pause 
echo.
echo.
echo ----------------Mostrando a Data e Hora---------------------------------------------
date
time
echo.
echo.
echo -------------Exibindo Usuario e o Nome Do Computador-------------------------
ECHO Usuário: %USERNAME%
ECHO Computador: %ComputerName%
PAUSE
echo.
echo.
pause
:menu
color 47
cls
echo ///////////////////////////////////////////////////////////////////////////////////////////
echo /...........................Digite para continuar........................................./
echo /........................................................................................../
echo /........................................................................................../
echo /.............[1] Abrir a ferramenta de gerenciamento do Computador......................../
echo /.............[2] Abrir as impressoras disponíveis........................................../
echo /.............[3] Abrir o Gerenciador de Serviços.........................................../
echo /.............[4] Abrir as conexoes de rede................................................./
echo /.............[5] Abrir o Controle de Usuarios............................................../
echo /........................................................................................../
echo /........................................................................................../
echo /........................................................................................../
echo ///////////////////////////////////////////////////////////////////////////////////////////
echo.
echo.
pause
set /p opcao=Digite a opcao desejada:
if "%opcao%" == "1" goto op1
if "%opcao%" == "2" goto op2
if "%opcao%" == "3" goto op3
if "%opcao%" == "4" goto op4
if "%opcao%" == "5" goto op5




: op1
taskmgr
set /p opc=Deseja sair ou voltar para o menu principal? [1] Sim / [2] Nao:
if "%opc%" == "1" goto ops1
if "%opc%" == "2" goto ops2

:  ops1
goto menu
:  ops2
goto fim





: op2
control printers
set /p opc=Deseja sair ou voltar para o menu principal? [1] Sim / [2] Nao:
if "%opc%" == "1" goto ops1
if "%opc%" == "2" goto ops2

:  ops1
goto menu
:  ops2
goto fim






: op3
services.msc
set /p opc=Deseja sair ou voltar para o menu principal? [1] Sim / [2] Nao:
if "%opc%" == "1" goto ops1
if "%opc%" == "2" goto ops2

:  ops1
goto menu
:  ops2
goto fim







: op4
ncpa.cpl
set /p opc=Deseja sair ou voltar para o menu principal? [1] Sim / [2] Nao:
if "%opc%" == "1" goto ops1
if "%opc%" == "2" goto ops2

:  ops1
goto menu
:  ops2
goto fim






: op5
control userpasswords 
set /p opc=Deseja sair ou voltar para o menu principal? [1] Sim / [2] Nao:
if "%opc%" == "1" goto ops1
if "%opc%" == "2" goto ops2

:  ops1
goto menu
:  ops2
goto fim





:fim
echo.
echo Operacao executada com sucesso !
echo.
echo Pressione qualuqer tecla para encerrar...
pause > nul