@echo off
setlocal
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0export-schema.ps1" %*
exit /b %ERRORLEVEL%
