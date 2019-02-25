# Introduction
The main purpose of this repo is to create a C Sharp project completely from VS Code, using an external class, and have it use NewstonSoft to read a JSON object. I created this with the standard terminal command

```
dotnet new console
```

Once that was done, I created a new class to represent a Hockey Team object with a constructor and overridden .ToString() method.

Used NuGet to get the following package;

```
dotnet add package Newtonsoft.Json --version 12.0.1
```

## Program.cs
Standard C#.NET console entry program

## HockeyTeam.cs
Base class used to reprsent a hockey team object that we will read from a JSON file. Overrode a constructor to be able to manually input teams in and .ToString() for display purposes.