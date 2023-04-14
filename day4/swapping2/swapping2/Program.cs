using System;
    public class swapp
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("enter the first number");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            number2=int.Parse(Console.ReadLine());
             temp = number1;
            number1 = number2;
            number2 = temp; 
            Console.WriteLine("after swapping");
            Console.WriteLine("first number is: " + number1);
            Console.WriteLine("second number is: " + number2);
            
        
        }
    }
