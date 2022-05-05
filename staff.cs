using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    class staff:person
    {
        private string department;
        private double salary;

        public staff() { }
        public staff(string name, int birthYear, string address, string department, double salary): base(name, birthYear,address)
        {
            this.department = department;
            this.salary = salary;
        }
        public override void input()
        {
            base.input();
            Console.Write("Khoa : ");
            department = Console.ReadLine();
            Console.Write("Luong: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            string baseinfo2 = base.ToString();
            return baseinfo2 + $"Department: {department}, Salary: {salary}";
        }
        public void updatesalary(double salary)
        {
            Console.Write("Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            this.salary = salary;
        }
    }
}
 