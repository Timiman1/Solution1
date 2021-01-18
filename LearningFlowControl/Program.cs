using System;

namespace LearningFlowControl
{
    class Program
    {
//        Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

//Show the text Unrecognized character if the operation symbol is different from the previous ones.

//You should use the switch block.
        static void Main(string[] args)
        {
            LearningDoWhile();
            BasicCalc();
            PositiveAndNegative();
        }

        static void BasicCalc()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            char operation = Convert.ToChar(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        static void PositiveAndNegative()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");
        }

        static void LearningWhile()
        {
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Type a number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num * 10);
            }
        }

        static void LearningDoWhile()
        {
            int x;

            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x * 10);
            }
            while (x != 0);
        }
    }
}
