using System;

namespace Bai_2
{
    class Program
    {
        static int[] a = new int[20];
        static int n, k, dem = 0;
        static bool[] check = new bool[20];
        static void XuatPhanTu(int[] a)
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void CHKL(int i)
        {
            for (int j = 1; j <= n; j++)
            {
                if (check[j] == false)
                {
                    a[i] = j;
                    if (i == k)
                    {
                        dem++;
                        XuatPhanTu(a);
                    }
                    else
                    {
                        check[j] = true;
                        CHKL(i + 1);
                        check[j] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            CHKL(1);
            Console.WriteLine($"Dem = {dem}");
        }
    }
}
