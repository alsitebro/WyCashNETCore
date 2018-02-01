# WyCashNETCore
.NET Core port of TDD example from Kent Beck's [Test-Driven Development By Example ISBN-10: 0-321-14653-0; ISBN-13: 978-0-321-14653-3](https://books.google.co.uk/books/about/Test_driven_Development.html?id=CUlsAQAAQBAJ&printsec=frontcover&source=kp_read_button&redir_esc=y#v=onepage&q&f=false)


* [.NET Core 2.0.0](https://github.com/dotnet/core/blob/master/release-notes/download-archive.md)
* [XUnit 2.3.1](https://xunit.github.io/docs/getting-started-dotnet-core.html)

## Setup
From within your solution folder (WyCash in this case. Replace '\\' with '/' for unix/linux based OS) run the following commands to get started:
```cmd
dotnet new sln
dotnet new xunit -o WyCash.Xunit
dotnet new classlib -o WyCash.Lib
dotnet sln WyCash.sln add .\WyCash.Xunit\WyCash.Xunit.csproj
dotnet sln WyCash.sln add .\WyCash.Lib\WyCash.Lib.csproj
dotnet add .\WyCash.Xunit\WyCash.Xunit.csproj reference .\WyCash.Lib\WyCash.Lib.csproj
mkdir .\WyCash.Xunit\Results
```

Create a batch script  - runtests.* - in WyCash.Xunit directory
* Windows batch script - runtests.cmd
```cmd
@echo off
dotnet test -t
dotnet xunit -verbose -xml .\Results\TestResults.xml
```
* Linux bash script runtests.sh
```bash
#!/bin/bash
dotnet xunit -verbose -xml Results/TestResults.xml
```
