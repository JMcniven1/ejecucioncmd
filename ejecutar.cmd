@echo off
if "%~1"=="" (
    echo Debes proporcionar la ruta al archivo .cmd que deseas ejecutar como parámetro.
    goto :EOF
)

set "rutaArchivo=%~1"
call "%rutaArchivo%"
