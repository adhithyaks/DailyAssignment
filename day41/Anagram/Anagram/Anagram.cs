using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Anagrams

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the first string:");

            string a = Console.ReadLine();

            Console.WriteLine("Enter the second string");

            string b = Console.ReadLine();

            Console.WriteLine(IsAnagram(a, b) ? "Anagram" : "Not Anagram");

        }

        static bool IsAnagram(string a, string b)

        {

            if (a.Length != b.Length)

            {

                return false;

            }

            char[] c1 = a.ToLower().ToCharArray();

            char[] c2 = b.ToLower().ToCharArray();

            Array.Sort(c1);

            Array.Sort(c2);

            for (int i = 0; i < c1.Length || i < c2.Length; i++)

            {

                if (c1[i] != c2[i]) { return false; }

            }

            return true;

        }

    }

}


