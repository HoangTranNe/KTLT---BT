using System;
class program
{
    static void Input(out int[] a)
    {
        Console.WriteLine("vui long nhap day so: ");
        int n = int.Parse(Console.ReadLine());
        a = new int [n];
        for(int i = 0; i < a.Length; i++)
        {
            for(int j = 0; j<a.Length; j++)
            {
                Console.Write($"Phan tu thu {i} = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        for(int i = 0; i < a.Length; i++)
        {
            for(int j = 0; i<a.Length; j++)
            {
                Console.Write($"a = {i}");
                Console.ReadLine();
            }
        }
        Console.ReadLine();
    }
    static bool IsPrime(int x)
    {
        int m = 0;
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                m++;
                return false;
            }
        }
        return true;
    }
    static List<int> FindAllPrime(int[] a)
    {
        Input(out a);
        List<int> result = new List<int>();
        result.Count();
        Console.WriteLine(result);
        return result;
    }
    static void InterchangeSort(List<int> intList)
    {
        int[] a = new int[intList.Count];
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int[] a;
        Input(out a);
        List<int> primeNumbers = FindAllPrime(a);
        if (primeNumbers.Count > 0)
            InterchangeSort(primeNumbers);
    }
} 
