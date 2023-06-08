using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;

namespace bigdecimal

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the number of string");

            int n = int.Parse(Console.ReadLine());

            string[] strarr = new string[n];

            Console.WriteLine("Enter the array:");

            for (int i = 0; n < strarr.Length; i++)

            {

                strarr[i] = Console.ReadLine();

            }

        }

    }

}
