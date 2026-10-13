@echo off
setlocal
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0setup-legacy-dependencies.ps1" %*
exit /b %ERRORLEVEL%
