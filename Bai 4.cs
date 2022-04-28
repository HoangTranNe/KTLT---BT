using System;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date A = new Date();
            Console.WriteLine($"Day = {A.getDay()}");
            Console.WriteLine($"Month = {A.getMonth()}");
            Console.WriteLine($"Year = {A.getYear()}");

            A.setDay(00);
            A.setMonth(00);
            A.setYear(0000);

            Console.WriteLine($"{A.ToString()}");
        }
    }
}
