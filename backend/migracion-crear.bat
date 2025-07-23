@echo off
set /p name=Nombre de la migracion: 
dotnet ef migrations add %name% --project DeadByDaylight.Infrastructure --startup-project DeadByDaylight.API
pause
