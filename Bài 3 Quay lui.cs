using System;

namespace Bai_3
{
        class Program
        {
            static int n, k, dem;
            static int[] arr = new int[20];
            static void Main(string[] args)
            {
                Console.Write(" nhap n= ");
                n = int.Parse(Console.ReadLine());
                Console.Write(" nhap k= ");
                k = int.Parse(Console.ReadLine());
                dem = 0;
                arr[0] = 0;
                chinhhoplap(1);
                Console.Write(dem);
            }
            static void xuat()
            {
                for (int i = 1; i <= k; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            static void chinhhoplap(int i)
            {
                for (int j = arr[i - 1] + 1; j <= n - k + 1; j++)
                {
                    arr[i] = j;
                    if (i == k)
                    {
                        dem++;
                        xuat();
                    }
                    else chinhhoplap(i + 1);
                }
            }
        }
    }
