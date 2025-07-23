@echo off
dotnet ef migrations remove --project DeadByDaylight.Infrastructure --startup-project DeadByDaylight.API
pause
