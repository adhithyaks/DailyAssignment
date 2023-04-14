using System;
namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, ch;
            Console.WriteLine("enter first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the available options are: ");
            Console.WriteLine("1.addition\n 2.subtraction\n 3.multiplication\n 4.division");
            Console.WriteLine("enter your choice");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("the sum of {0} and {1} is {2}", number1, number2, number1 + number2);
                    break;
                case 2:
                    Console.WriteLine("the subtraction of {0} and {1} is {2}", number1, number2, number1 - number2);
                    break;
                case 3:
                    Console.WriteLine("the multiplication of {0} and {1} is {2}", number1, number2, number1 * number2);
                    break;
                case 4:
                    Console.WriteLine("the division of {0} and {1} is {2}", number1, number2, number1 / number2);
                    break;
                default:
                    Console.WriteLine("input incorrect choice\n");
                    break;

            }

        }
    }
}
