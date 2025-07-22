using System;

class Calculator
{
    public int Calculate(int a, int b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b != 0 ? a / b : throw new DivideByZeroException(),
            '%' => a % b,
            _ => throw new ArgumentException("Invalid operator")
        };
    }

    public double Calculate(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b != 0 ? a / b : throw new DivideByZeroException(),
            '%' => a % b,
            _ => throw new ArgumentException("Invalid operator")
        };
    }

    public double Calculate(double a, double b, double c, char op)
    {
        return op switch
        {
            '+' => a + b + c,
            '-' => a - b - c,
            '*' => a * b * c,
            '/' => (b != 0 && c != 0) ? a / b / c : throw new DivideByZeroException(),
            '%' => a % b % c,
            _ => throw new ArgumentException("Invalid operator")
        };
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        bool continueCalc = true;

        while (continueCalc)
        {
            //Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("==== Calculator with ReadLine() ====");

            Console.Write("How many numbers? (2 or 3): ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /, %): ");
            string opInput = Console.ReadLine();
            char op = opInput.Length > 0 ? opInput[0] : '+';

            try
            {
                if (count == 2)
                {
                    Console.Write("Enter first number: ");
                    string input1 = Console.ReadLine();

                    Console.Write("Enter second number: ");
                    string input2 = Console.ReadLine();

                    if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
                    {
                        int result = calc.Calculate(int1, int2, op);
                        Console.WriteLine($"\nResult (int): {int1} {op} {int2} = {result}");
                    }
                    else if (double.TryParse(input1, out double d1) && double.TryParse(input2, out double d2))
                    {
                        double result = calc.Calculate(d1, d2, op);
                        Console.WriteLine($"\nResult (double): {d1} {op} {d2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else if (count == 3)
                {
                    Console.Write("Enter first number: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Enter third number: ");
                    double c = double.Parse(Console.ReadLine());

                    double result = calc.Calculate(a, b, c, op);
                    Console.WriteLine($"\nResult (3-values): {a} {op} {b} {op} {c} = {result}");
                }
                else
                {
                    Console.WriteLine("❌ Please enter only 2 or 3 numbers.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error: " + ex.Message);
            }

            Console.Write("\nDo you want to calculate again? (y/n): ");
            string again = Console.ReadLine();
            continueCalc = (again.ToLower() == "y");
        }

        Console.WriteLine("\n👋 Thank you for using the calculator!");
    }
}
