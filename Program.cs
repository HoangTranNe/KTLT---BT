using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            person hoang = new person();
            student bao = new student();
            staff tran = new staff();

            hoang.input();
            bao.input();
            tran.input();

            hoang.GetAge();

            Console.WriteLine(hoang);
            Console.WriteLine(bao);
            Console.WriteLine(tran);
            Console.ReadKey();
        }
    }
}
