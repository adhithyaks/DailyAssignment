using System;

using System.Collections.Generic;

using System.Linq;

using System.Numerics;

using System.Text;

using System.Threading.Tasks;

namespace QSTN3

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter 1 number");

            BigInteger b1 = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 number");

            BigInteger b2 = BigInteger.Parse(Console.ReadLine());

            BigInteger b3 = b1 + b2;

            Console.WriteLine("Sum:" + b3);

            BigInteger b4 = b1 * b2;

            Console.WriteLine("Multiplication:" + b4);

        }

    }

}

