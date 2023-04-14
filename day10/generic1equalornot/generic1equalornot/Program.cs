using System;
using System.Diagnostics.Eventing.Reader;

namespace generic1equalornot
{
    public class Program
    {
       private static void Main()
        { 
            bool IsEqual=clscalculator.AreEqual(20,20);
            if (IsEqual)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("both are not equal");
            }
        }
            
       

    }
}
