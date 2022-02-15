echo off
cls
echo ------------------------Mudando de cor------------------------------------------
color 60
echo.
echo.
pause 
echo.
echo.
echo ----------------Mostrando a Data e hora---------------------------------------------
date
time
echo.
echo.
echo -------------Exibindo Usuario e o nome do computador-------------------------
ECHO %USERNAME%
ECHO %ComputerName%
PAUSE
echo.
echo.
echo ---------------Configura~cao ip---------------------------------------------------
IPCONFIG
PAUSE
echo.
echo.
echo --------------Informacao basica do sistema-----------------------------------------
echo.
echo.
systeminfo
pause
echo.
echo.
echo -----------------Processos executados no windows-------------------------------------
echo.
echo.
tasklist
echo.
echo.
echo.
echo Operacao executada com sucesso !
echo.
echo Pressione qualuqer tecla para encerrar...
pause > nul

