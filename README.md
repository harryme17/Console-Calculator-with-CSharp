# Console Calculator in C# (Method Overloading + ReadLine)

This is a simple **C# console-based calculator** that supports basic arithmetic operations (`+`, `-`, `*`, `/`, `%`) on **two or three numbers**. It uses **method overloading** to handle different data types (`int`, `double`) and number counts. The program reads user input from the console using `Console.ReadLine()` and uses **C# 8.0 switch expressions** for clean, readable logic.

## 🚀 Features

-   Perform arithmetic operations: `+`, `-`, `*`, `/`, `%`
    
-   Supports both `int` and `double` numbers
    
-   Choose to enter **2 or 3 numbers**
    
-   **Method overloading** for different input types and argument counts
    
-   Handles:
    
    -   **Divide by zero** errors
        
    -   **Invalid input** gracefully
        
-   Option to repeat calculations in a loop
## Concepts Used

-   `Method Overloading`
    
-   `switch` expression
    
-   `TryParse()` and `Parse()`
    
-   `Exception Handling`
    
-   `Console.ReadLine()` input handling
    
-   `Ternary Operator`
    
-   `while` loop

## 🛠️ How It Works

1.  Program asks: `How many numbers? (2 or 3)`
    
2.  User provides an operator: `+`, `-`, `*`, `/`, `%`
    
3.  Based on count:
    
    -   For **2 numbers**: Accepts and evaluates `int` or `double`
        
    -   For **3 numbers**: Only supports `double` input for simplicity
        
4.  Calls the appropriate overloaded `Calculate()` method
    
5.  Displays the result with proper formatting
    
6.  Asks if the user wants to perform another calculation

## 🧾 Example Run


```==== Calculator with ReadLine() ====
How many numbers? (2 or 3): 2
Enter operator (+, -, *, /, %): *
Enter first number: 4
Enter second number: 5

Result (int): 4 * 5 = 20

Do you want to calculate again? (y/n): y
```

## 📁 File Structure

```
`CalculatorApp/
│
├── Program.cs # Main entry point, user interaction logic └── Calculator.cs # Contains overloaded Calculate() methods. 
```

## 📌 Notes

-   The default operator is `'+'` if none is entered.
    
-   The program uses: 
```
char op = opInput.Length > 0 ? opInput[0] : '+';
```

## 🙋‍♂️ Author

**Harshal Menge**  
This project is a beginner-friendly C# practice tool focusing on method overloading and console-based interaction.
