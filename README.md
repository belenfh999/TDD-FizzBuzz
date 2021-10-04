# TDD-FizzBuzz
Implementation of the FizzBuzz Algorithm to learn TDD.
## The FizzBuzz Algorithm
* **Input**
Positive number **N**
* **Output** (condition -> **output)**
  * N is divisible by 3     ->   "Fizz" 
  * N is divisible by 5     ->   "Buzz"
  * N is divisible by 3 & 5 -> "FizzBuzz"
  * Otherwise               ->     N
## Creating the project from scratch
* Go to the directory where you want your project to be and run:
 
```dotnet new sln -o TDD-FizzBuzz```
* Go to that newly created directory 

```cd unit-testing-using-dotnet-test```
* Create a new class lib: 

```dotnet new classlib -o FizzBuzz.Library```

**NOTE:** The dotnet new classlib command creates a new class library project in the FizzBuzz.Library folder. The new class library will contain the code to be tested.

* Rename the file Class1.cs to FizzBuzzService.cs

```mv ./FizzBuzz.Library/Class1.cs ./FizzBuzz.Library/FizzBuzzService.cs```

* Run the following command to add the class library project to the solution:

```dotnet sln add ./FizzBuzz.Library/FizzBuzz.Library.csproj```
