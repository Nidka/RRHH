@echo off
setlocal
"%SystemRoot%\SysWOW64\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -ExecutionPolicy Bypass -File "%~dp0check-postgresql.ps1" %*
exit /b %ERRORLEVEL%
