using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividebyzerowithfinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 10;
            int i = -1;
            int[] a = new int[5];

            try
            {
                i = t / i;
                a[10] = i;
                Console.WriteLine(t);

            }

            catch (DivideByZeroException e )
            {
                Console.WriteLine("i is the error its zero");

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("out of boundary");
            }
            finally
            {
                Console.WriteLine("done");
            }
        }
    }
}
