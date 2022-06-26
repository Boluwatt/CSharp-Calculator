using System;

namespace Calculator
    {
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();

            while (true)
            {
                Console.WriteLine("Input first number");

                int firstNum = 0;

                string num1 = Console.ReadLine();

                if (!int.TryParse(num1, out firstNum))
                {
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                    continue;
                }

                firstNum = Int32.Parse(num1);

                int secondNum = 0;

                Console.WriteLine("Input second number");

                string num2 = Console.ReadLine();

                if (!int.TryParse(num2, out secondNum))
                {
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                }

                secondNum = Int32.Parse(num2);

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("What mathematical operation do you want to perform?");
                Console.WriteLine("A - Addition");
                Console.WriteLine("B - Subtraction");
                Console.WriteLine("C - Multiplication");
                Console.WriteLine("D - Division");

                Console.ResetColor();

                string mathOp = Console.ReadLine().ToUpper();

                int answer = 0;

                if (mathOp == "A")
                {
                    answer = firstNum + secondNum;

                    PrintColorMessage(ConsoleColor.Green, "The answer is ");
                    Console.WriteLine(answer);
                }
                else if (mathOp == "B")
                {
                    answer = firstNum - secondNum;

                    PrintColorMessage(ConsoleColor.Green, "The answer is ");
                    Console.WriteLine(answer);
                }
                else if (mathOp == "C")
                {
                    answer = firstNum * secondNum;

                    PrintColorMessage(ConsoleColor.Green, "The answer is ");
                    Console.WriteLine(answer);
                }
                else if (mathOp == "D")
                {
                    answer = firstNum / secondNum;

                    PrintColorMessage(ConsoleColor.Green, "The answer is ");
                    Console.WriteLine(answer);
                }
                else
                {
                    PrintColorMessage(ConsoleColor.Red, "Please enter a valid response");
                }
            }
        }                                     
        static void AppInfo()
        {
            string appName = "Calculator";
            string appVersion = "1.0.0";
            string appAuthor = "Boluwatife Oluwagbamila";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}

