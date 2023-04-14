using System;
using Syst

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            double area;
            Console.WriteLine("Enter Radius:");
            r = int.Parse(Console.ReadLine());
            area = circle(r);
            Console.WriteLine("area of circle having radius {0} is {1}", r, area);

        }
        static double circle(double r)

        {
            double area ;
            area = 3.14 * r * r;
            return area;
        }
    }
}
