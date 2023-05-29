using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{


class Solution
        {
            static void Main()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (int num in arr)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
    

