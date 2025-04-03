using System;

class Program
{
    enum Operation { Add, Subtract, Multiply, Divide }

    static void Main()
    {
        while (true)
        {
            try
            {
                while (true)
                {
                    Console.Write("enter first number: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter second number");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter operator +,-,*,/");
                    char solution = char.Parse(Console.ReadLine());

                    Dictionary<char, Operation> operationMap = new Dictionary<char, Operation>
                {
                    { '+', Operation.Add },
                    { '-', Operation.Subtract },
                    { '*', Operation.Multiply },
                    { '/', Operation.Divide }

                };

                    if (!operationMap.ContainsKey(solution))
                        throw new ArgumentException("Invalid operation! Please enter +, -, * or /.");

                    Operation operation = operationMap[solution];

                    double result = PerformCalculation(x, y, operation);

                    Console.WriteLine($"Result: {result}");

                    Console.WriteLine("do you want to perform another operation?\nif yes enter 1 \nif no enter 2");
                    int response = int.Parse(Console.ReadLine());

                    
                    if (response == 2)
                    {
                        Console.WriteLine("thank you for using this service");
                        break;
                    }
                    
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input! please enter numeric values.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("error! division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an unexpected error occurred: {ex.Message}");
            }

        }
        static double PerformCalculation(double x, double y, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add: return x + y;
                case Operation.Subtract: return x - y;
                case Operation.Multiply: return x * y;
                case Operation.Divide:
                    if (y == 0)
                        throw new DivideByZeroException();
                    return x / y;
                default:
                    throw new ArgumentException("Invalid operation!");
            }

        }
    }


}

