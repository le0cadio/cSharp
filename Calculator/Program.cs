using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Exit");
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Division();
                    break;
                case 4:
                    Multiplication();
                    break;
                case 5:
                    SquareRoot();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + (firstNumber + secondNumber));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + (firstNumber - secondNumber));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + (firstNumber / secondNumber));
            Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + (firstNumber * secondNumber));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Menu();
        }

        static void SquareRoot()
        {
            Console.Clear();
            Console.WriteLine("Please enter your number: ");
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: " + Math.Sqrt(number));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Menu();
        }
    }
}