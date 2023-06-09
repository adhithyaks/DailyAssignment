﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class SubarraySum
{
    public ArrayList subArraySum(int[] arr, int n, int s)
    {
        int sum = 0;
        int i = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + arr[j];
            while (sum > s)
            {
                sum -= arr[j];
                i++;
            }
            if (sum == s)
            {
                ArrayList result = new ArrayList();
                result.Add(i + 1);
                result.Add(j + 1);
                return result;
            }
        }
        return new ArrayList { -1 };
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {
        int S;
        int[] arr = new int[10];
        int N = arr.Length;
        N = int.Parse(Console.ReadLine());
        S = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        SubarraySum s = new SubarraySum();
        ArrayList result = s.subArraySum(arr, N, S);
        Console.WriteLine(result[0] + "" + result[1]);
    }
}


