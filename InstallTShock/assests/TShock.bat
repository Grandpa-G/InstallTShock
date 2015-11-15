@echo on
`drive
cd "`folder"
ECHO ON
title Terraria Server

:start
cls

TerrariaServer.exe `commandline
@echo.
@echo Restarting server...
@echo.

echo Waiting `delay seconds - CTRL-C to get out
timeout /t `delay

goto start