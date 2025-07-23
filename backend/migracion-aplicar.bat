@echo off
dotnet ef database update --project DeadByDaylight.Infrastructure --startup-project DeadByDaylight.API
pause
