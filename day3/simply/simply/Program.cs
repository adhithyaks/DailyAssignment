//Write a C# Sharp program to swap two numbers.
using System;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1, number2,temp;
            Console.WriteLine("ENTER THE FIRST NUMBER");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            number2=int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            temp = number2;
            Console.WriteLine("After swapping");
            Console.WriteLine("FIRST NUMBER IS: ", +number1);
            Console.WriteLine("SECOND NUMBER IS: ", +number2);
            Console.Read();
            

           
        }
    }
}
