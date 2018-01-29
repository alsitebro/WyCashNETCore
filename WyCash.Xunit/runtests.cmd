@echo off
dotnet test -t
dotnet xunit -appveyor -xml .\Results\TestResults.xml