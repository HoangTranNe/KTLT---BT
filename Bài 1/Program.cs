using System;
namespace BT1___MOODLE
{
    class Program
    {
        static void NhapMang1(out int [,] a)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            a = new int[r, c];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"data[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static int[,] NhapMang2()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int [,] b = new int[r, c];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"data[{i},{j}] = ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return b;
        }
        static void NhapMang3(int[,] c)
        {
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"data[{i},{j}] = ");
                    c[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mang a : ");
            int[,] a;
            NhapMang1(out a);
            Console.WriteLine("Mang a vua nhap la ");
            XuatMang(a);
            Console.WriteLine("Nhap mang b : ");
            int[,] b;
            b = NhapMang2();
            Console.WriteLine("Mang b vua nhap la : ");
            XuatMang(b);
            Console.WriteLine("Nhap mang c : ");
            int m, n;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] c = new int[m, n];
            NhapMang3(c);
            Console.Write("Mang c vua nhap la : ");
            XuatMang(c);
        }
    }
}