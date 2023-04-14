using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount :");
            int amount=int.Parse(Console.ReadLine());
            int w = amount / 2000;
            amount = amount % 2000;
            Console.WriteLine("no of 2000 notes :" +w);
            int x = amount / 500;
            amount = amount % 500;
            Console.WriteLine("no of 500 notes :" + x);
            int y = amount / 200;
            amount = amount % 2000;
            Console.WriteLine("no of 200 notes :" + y);
            int z = amount / 100;
            amount = amount % 100;
            Console.WriteLine("no of 100 notes :" + z);
            int m = amount / 50;
            amount = amount % 50;
            Console.WriteLine("no of 50 notes :" + m);
            int n = amount / 10;
            amount = amount % 10;
            Console.WriteLine("no of 10 notes :" + n);
            int o = amount / 5;
            amount = amount % 5;
            Console.WriteLine("no of 5 notes :" + o);
            int p = amount / 2;
            amount = amount % 2;
            Console.WriteLine("no of 2 notes :" + p);
            int q = amount / 1;
            amount = amount % 1;
            Console.WriteLine("no of 1 notes :" + q);
            Console.ReadKey();
        }
    }
}
