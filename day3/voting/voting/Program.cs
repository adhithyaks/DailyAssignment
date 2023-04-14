using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter your age:");
            age = int.Parse(Console.ReadLine());
            int res = voting(age);
            if (res == 1)
            {
                Console.WriteLine("the person can vote");
            }
            else
            {
                Console.WriteLine("the person cant vote");
            }
            Console.ReadKey();
        }
            static int voting(int a)
            {
                if (a >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }






            }
        }
    }

