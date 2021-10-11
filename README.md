# TDD-FizzBuzz

Implementation of the FizzBuzz Algorithm to learn TDD using C#.
Two testing framework that will be used is xUnit.

## The FizzBuzz Algorithm

- **Input**

  - Positive number **N**

- **Output** (condition -> **output)**
  - N is divisible by 3 -> "Fizz"
  - N is divisible by 5 -> "Buzz"
  - N is divisible by 3 & 5 -> "FizzBuzz"
  - Otherwise -> N

## Prerequisites

| **Programming Language** | **Testing Framework** | **Code editor**    | **Runtime** |
| ------------------------ | --------------------- | ------------------ | ----------- |
| C#                       | xUnit                 | Visual Studio Code | .NET Core   |

## Creating The Project using a bash script

- Give execution permissions to create_project_TDD.sh in case it does not have them:

`chmod +x create_project_TDD.sh`

- Simply execute the bash script giving it as a parameter the name of the Project:

`./create_project_TDD.sh ImmutableStack`

**NOTE:** The script will check whether dotnet is installed and in case it is not, it will install it (only available for LINUX/MACOSX computers).

## Creating The Project From Scratch

- Go to the directory where you want your project to be and run:

`dotnet new sln -o TDD-FizzBuzz`

- Go to that newly created directory

`cd TDD-FizzBuzz`

- Create a new class lib:

`dotnet new classlib -o FizzBuzz.Library`

**NOTE:** The dotnet new classlib command creates a new class library project in the FizzBuzz.Library folder. The new class library will contain the code to be tested.

- Rename the file Class1.cs to FizzBuzzService.cs

`mv ./FizzBuzz.Library/Class1.cs ./FizzBuzz.Library/FizzBuzzService.cs`

- Run the following command to add the class library project to the solution:

`dotnet sln add ./FizzBuzz.Library/FizzBuzz.Library.csproj`

- Create the FizzBuzz.Tests project by running the following command:

`dotnet new xunit -o FizzBuzz.Tests`

- Rename the file UnitTest1.cs to FizzBuzzTests.cs

`mv ./FizzBuzz.Tests/UnitTest1.cs ./FizzBuzz.Tests/FizzBuzzTests.cs`

- Add the test project to the solution file by running the following command:

`dotnet sln add ./FizzBuzz.Tests/FizzBuzz.Tests.csproj`

- Add the FizzBuzzService class library as a dependency to the FizzBuzz.Tests project:

`dotnet add ./FizzBuzz.Tests/FizzBuzz.Tests.csproj reference ./FizzBuzz.Library/FizzBuzz.Library.csproj`

## Running the tests

- To run the tests, use the following command:

`dotnet test`

- Here's an example of what an execution will look like:

```
TDD-FizzBuzz git:(main) ✗ dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  FizzBuzz.Library -> /Users/belen/Desktop/TDD The Big Picture/TDD-FizzBuzz/FizzBuzz.Library/bin/Debug/net5.0/FizzBuzz.Library.dll
  FizzBuzz.Tests -> /Users/belen/Desktop/TDD The Big Picture/TDD-FizzBuzz/FizzBuzz.Tests/bin/Debug/net5.0/FizzBuzz.Tests.dll
Test run for /Users/belen/Desktop/TDD The Big Picture/TDD-FizzBuzz/FizzBuzz.Tests/bin/Debug/net5.0/FizzBuzz.Tests.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:    17, Skipped:     0, Total:    17, Duration: 38 ms - /Users/belen/Desktop/TDD The Big Picture/TDD-FizzBuzz/FizzBuzz.Tests/bin/Debug/net5.0/FizzBuzz.Tests.dll (net5.0)
```
