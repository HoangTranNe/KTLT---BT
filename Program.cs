using System;
class program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            List<int> btb = new List<int>(n);
            btb.Add(n);
            btb.Remove(n);
            Console.WriteLine("Count is :" + btb.Count);
            Console.WriteLine("Capacity is : " + btb.Capacity);
        }
        Console.ReadLine();
    }
}