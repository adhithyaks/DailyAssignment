using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 56, 44, 3, 24, 90, 11 };
            int temp;
            for(int i=0; i<6; i++)
            {
                Console.WriteLine(ar[i] + "\t");
            }
            Console.WriteLine();
            for (int j=0; j<ar.Length-1;j++)
            {
                for (int i=j;i<ar.Length-1;i++)
                {
                    if (ar[j] > ar[i+1])
                    {
                        temp = ar[j];
                        ar[j] = ar[i+1];
                        ar[i+1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted arrray is: ");
            for(int i= 0; i<6; i++)
            {
                Console.WriteLine(ar[i] + "\t");
            }
            Console.WriteLine() ;
        }
    }
}
