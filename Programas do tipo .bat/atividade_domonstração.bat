@echo off
cls
echo.
echo.
echo Digite o numero da opcao desejada
echo.
echo.
echo [1] Ativar o usuário Administrador 
echo [2] Desativar o usuario Administrador 
echo [3] Sair sem fazer nada

set /p opcao=Digite a opcao desejada:

if "%opcao%" == "1" goto op1
if "%opcao%" == "2" goto op2
if "%opcao%" == "3" goto op3

: op1
net user administrador /active:yes > nul
goto fim

: op2
net user administrador /active:no > nul
goto fim

: op3
exit

:fim
echo.
echo Operacao executada com sucesso !
echo.
echo Pressione qualuqer tecla para encerrar...
pause > nul