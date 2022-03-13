/* Khai báo và khởi tạo một List số nguyên. In ra màn hình
giá trị thuộc tính Count và Capacity của List*/
using System;
class program
{  
    static void Main()
    {

        List<int> btA = new List<int>(10);
        btA.Add(1);
        btA.Add(2);
        btA.Add(3);
        btA.Add(4);
        btA.Add(5);
        btA.Add(6);
        btA.Add(7);
        btA.Add(8);
        btA.Add(9);
        btA.Add(10);

        btA.RemoveAt(1);
        btA.RemoveAt(2);

        Console.WriteLine($"Count after add 10: {btA.Count}");
        Console.WriteLine($"Capacity after add 10: {btA.Capacity}");
        Console.ReadLine();

    }
}
