namespace Bài_4;

public class Class1
{
    static void Main()
    {
        Console.Write("Nhap m, n, k: ");
        string[] token = Console.ReadLine().Split();
        int m = int.Parse(token[0]);
        int n = int.Parse(token[1]);
        int k = int.Parse(token[2]);
        int[,] a = new int [m, n];

        SumR(m, n, k, a);
        SumC(m, n, k, a);
    }

    static void SumR(int m, int n, int k, int[,] a)
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
            Console.Write(sum);
        }
    }

    static void SumC(int m, int n, int k, int[,] a)
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
            Console.Write(sum);
        }
    }
}