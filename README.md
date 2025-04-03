# Simple Calculator in C#

# Overview
This is a console-based calculator written in C#. It allows users to perform basic arithmetic operations (addition, subtraction, multiplication, and division) using an interactive interface. The program supports input validation, exception handling, and a loop for multiple calculations.

# Features
- Supports four operations: Addition (+), Subtraction (-), Multiplication (*), and Division (/)  
- Uses enum for defining mathematical operations  
- Implements Dictionary<char, Operation> for mapping user input  
- Exception Handling: Prevents invalid inputs and division by zero  
- Allows repeated calculations until the user chooses to exit  

# How It Works
1. User enters two numbers.
2. User selects an operation ('+', '-', '*', '/').
3. The program performs the calculation.
4. Displays the result.
5. The user can choose to continue or exit.

## Technologies Used
- C# (Console Application)
- .NET Core / .NET Framework
- Exception Handling (`try-catch`)
- Data Structures (`Dictionary`)
- Enums (`enum Operation`)

