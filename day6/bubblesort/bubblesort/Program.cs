using System;


namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] intArray = new int[5];
            Console.WriteLine("enter the array elements:");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j<=intArray.Length-2;j++)
            {
                for(int i=0;i<intArray.Length-2;i++)
                {
                    count = count + 1;
                    if (intArray[i] > intArray[i+1])
                    {
                        int temp = intArray[i+1];
                        intArray[i+1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting array:");
            foreach(int item in intArray)
            {
                Console.Write(item + "");
            }
            Console.WriteLine();
            Console.WriteLine("the loop iterates:" + count);
            Console.ReadKey();
        }
    }
}
