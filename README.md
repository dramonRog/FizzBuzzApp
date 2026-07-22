# FizzBuzzApp

[![.NET](https://img.shields.io/badge/.NET-10.0-purple.svg)](https://dotnet.microsoft.com/download)
[![Tests](https://img.shields.io/badge/tests-xUnit-blue.svg)](#how-to-run-the-tests)

## Task Overview

The application processes an alphanumeric string and replaces specific words based on their position index:
* Every **3rd** word is replaced with `Fizz`.
* Every **5th** word is replaced with `Buzz`.
* Every **15th** word is replaced with `FizzBuzz`.

**Key Constraints Handled:**
* The length of the input string is strictly validated (7 <= |s| <= 100).
* Punctuations and whitespaces are ignored during alphanumeric word counting but are strictly preserved in the final output string.
* No third-party libraries or built-in utilities were used for the core FizzBuzz detection logic.

## Project Structure

The solution consists of two main projects: a Console Application for the core logic and an xUnit test project for quality assurance.

```text
FizzBuzzApp
 ┣ FizzBuzzApp                 # Main Console Application
 ┃ ┣ FizzBuzzDetector.cs       # Core algorithmic logic
 ┃ ┣ FizzBuzzResult.cs         # Data model for the output
 ┃ ┣ Program.cs                # Entry point & task example runner
 ┃ ┗ FizzBuzzApp.csproj
 ┣ FizzBuzzApp.Tests           # Unit Tests Project
 ┃ ┣ FizzBuzzDetectorTests.cs  # xUnit tests covering edge cases
 ┃ ┗ FizzBuzzApp.Tests.csproj
 ┣ .editorconfig               # Google C# Style Guide rules (2 spaces, etc.)
 ┣ FizzBuzzApp.slnx            # Solution file
 ┗ README.md

```

## Prerequisites

To build and run this application, ensure you have the **[.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)** installed on your machine.

## How to Run the Application

1. Clone the repository to your local machine:
```bash
git clone https://github.com/dramonRog/FizzBuzzApp.git

```


2. Navigate to the root folder of the repository:
```bash
cd FizzBuzzApp

```


3. Run the console application:
```bash
dotnet run --project FizzBuzzApp/FizzBuzzApp.csproj

```



*(The application will automatically process and output the result of the example string provided in the technical task).*

## How to Run the Tests

The solution includes a test suite built with **xUnit**. It contains 5 comprehensive unit tests verifying business logic, punctuation handling, and constraints validation (null inputs, string length limits).

To execute the tests, run the following command from the root directory:

```bash
dotnet test FizzBuzzAppTests/FizzBuzzApp.Tests.csproj

```

**Author:** Roman Buchynskyi
