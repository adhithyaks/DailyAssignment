using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnfromananonymousmethod
{
    internal class Program
    {
        public delegate int sum(int i, int j);

        static void Main(string[]args)
        {
            int result;
            sum s = delegate (int a, int b)
            {
                return a + b;
            };
            result = s(10, 20);
            Console.WriteLine(result);
        }
    }
}
