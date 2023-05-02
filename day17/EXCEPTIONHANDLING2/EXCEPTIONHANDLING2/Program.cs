using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTIONHANDLING2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 10;
           int i = -1;
            try
            {
                t = t / i;
                Console.WriteLine(t);

            }
            catch(Exception ex) 
            {
                Console.WriteLine("i is the error");

            }

            finally
            {
                Console.WriteLine("done");
            }
        }
    }
}
