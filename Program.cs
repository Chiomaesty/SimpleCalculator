class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("enter first number: ");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("please enter the right number");
            }
            Console.Write("enter second number: ");
            double y;
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("please enter the right number");
            }

            Console.WriteLine("enter operator +,-,*,/");
            char solution = char.Parse(Console.ReadLine());

            while (true)
            {
                switch (solution)
                {
                    case '-':
                        Console.WriteLine($"the answer is {x - y}");
                        Console.WriteLine();
                        break;
                    case '+':
                        Console.WriteLine($"the answer is {x + y}");
                        Console.WriteLine();
                        break;
                    case '*':
                        Console.WriteLine($"the answer is {x * y}");
                        Console.WriteLine();
                        break;
                    case '/':
                        Console.WriteLine($"the answer is {x / y}");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                }
                break;
            }
            Console.WriteLine("do you want to perform another operation?\nif yes enter 1 \nif no enter 2");
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || response < 0||response >2)
            {
                Console.WriteLine("please select the right option");
            }

            if (response == 2)
            {
                Console.WriteLine("thank you for using this service");
                break;
            }

        }

    }

}

