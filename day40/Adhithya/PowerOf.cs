using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf
{
    class Inner
    {
        private class Private
        {
            public bool Power(int num)
            {
                if (num == 0)
                    return false;

                while (num != 1)
                {
                    if (num % 2 != 0)
                        
                        return false;

                    num = num / 2;
                }
                return true;
            }
        }

        class Solution
        {

            static void Main(string[] args)
            {
                Inner.Private temp = new Inner.Private();


                Console.WriteLine("Enter a number");

                int num = int.Parse(Console.ReadLine());
                if (temp.Power(num))
                {

                    Console.WriteLine("{0} is a power of 2", num);
                }

                else

                    Console.WriteLine("{0} is not a power of 2", num);

            }

        }

    }

}
        