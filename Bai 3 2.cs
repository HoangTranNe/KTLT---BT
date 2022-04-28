using System;

namespace Bai_3
{
    class program
    {
        static void Main()
        {
            rectangle N1 = new rectangle();
            rectangle N2 = new rectangle();
            N1.input();
            Console.WriteLine($"Perimeter = {N1.GetPerimeter()}");
            Console.WriteLine($"Area = {N1.GetArea()}");
            N2.input();
            Console.WriteLine($"Perimeter = {N2.GetPerimeter()}");
            Console.WriteLine($"Area = {N2.GetArea()}");
        }
        
    }
}
