using System.Reflection.Metadata;
using System.Xml;

namespace Bài_4;

public class Class1
{
    static void NhapMang(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }

    static int SumR(int[,] a, int k)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (k == i)
                {
                    sum += a[k, j];
                }
            }
        }

        return sum;
    }

    static int SumC(int[,] a, int k)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (k == j)
                {
                    sum += a[k, i];
                }
            }
        }

        return sum;
    }

    static int Suma(int[,] a)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sum += a[i, j];
            }
        }

        return sum;
    }

    static int SumChan(int[,] a)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] / 2 == 0)
                {
                    sum += a[i, j];
                }
                else Console.Write("invalid result!");
            }
        }

        return sum;
    }
    static int SumLe(int[,] a)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] / 2 != 0)
                {
                    sum += a[i, j];
                }
                else Console.Write("invalid result!");
            }
        }

        return sum;
    }

    static int TrungBinh(int[,] a)
    {
        int sum = 0;
        int average = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sum += a[i,j];
                average = sum / a.Length;
            }
        }

        return average;
    }
    static void Main()
    {
        Console.Write("nhap m,n,k = ");
        string[] token = Console.ReadLine().Split();
        int m = int.Parse(token[0]);
        int n = int.Parse(token[1]);
        int k = int.Parse(token[2]);
        int[,] a = new int [m, n];
        NhapMang(a);
        Console.WriteLine($"tong cac phan tu o dong {k} la : {SumR(a,k)}");
        Console.WriteLine($"tong cac phan tu o cot  {k} la : {SumC(a,k)}");
        Console.WriteLine($"tong cac phan tu o trong a la  : {Suma(a)}");
        Console.WriteLine($"tong cac phan tu so chan trong a la : {SumChan(a)}");
        Console.WriteLine($"tong cac phan tu so le trong a la : {SumLe(a)}");
        Console.WriteLine($"trung binh cac phan tu trong a la : {TrungBinh(a)}");
    }
}