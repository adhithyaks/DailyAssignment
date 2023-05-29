using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sentence");

            string input = Console.ReadLine();

            string output = Regex.Replace(input, @"(?i)\b(\w+)(\s+\1)+\b", "$1");

            Console.WriteLine(output);

        }
    }
}