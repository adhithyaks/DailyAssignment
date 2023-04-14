using System;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the first number");
            x = int.Parse(Console.ReadLine());
            int y;
            Console.WriteLine("Enter the second number");
            y = int.Parse(Console.ReadLine());
            int result = sumofnumbers(x, y);
            Console.WriteLine("the result is {0}", result);
        }



            static int sumofnumbers(int x , int y)
            {
                if (x == y)
                {
                    int ans = (x + y) * 3;


                    return ans;
                }
                else
                {
                    int ans1 = ( x + y) ;
                    return ans1;
                }



        }
    }
}
