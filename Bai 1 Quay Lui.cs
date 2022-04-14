using System;

namespace Bai_1
{
    class Program
    {
        static int[] a = new int[100];
        static void Try(int i,int k,int n)
        {
            for(int j =1;j<=n;j++)
            {
                a[i] = j;
                if (i == k)
                {
                    for(int h = 1;h<=k;h++)
                    {
                        Console.Write(a[h] + " ");
                    }
                    Console.WriteLine();
                }
                else Try(i + 1, n, k);
            }
        }
        static void Main()
        {
            string[] token = Console.ReadLine().Split();
            int n = int.Parse(token[0]);
            int k = int.Parse(token[1]);
            Try(1, k, n);
        }
    }
}
