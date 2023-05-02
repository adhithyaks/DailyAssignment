using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        static void Add(int i, int j)
        {
            Console.WriteLine("sum" + (i + j));
        }
        static void Sub(int i, int j)
        {
            Console.WriteLine("Sub" + (i - j));
        }
        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            //Add(20, 20);
            //reftomethod r1 = Add;
            //r1(10, 20);
            //reftomethod r2 = Sub;
            //r2(10, 20);

            //MULTIPLE DELEGATION

            reftomethod multicast = Add;
            multicast += Sub;
            multicast(10, 90);
            Console.WriteLine("after removing sub");
            multicast -= Sub;
            multicast(10, 90);

        }
    }
}
