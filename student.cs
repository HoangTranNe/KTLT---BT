using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    class student:person
    {
        private string program;
        private int year;

        public student() { }
        public student (string name, int birthYear, string address,string program, int year): base (name,birthYear,address)
        {
            this.program = program;
            this.year = year;
        }
        public override void input()
        {
            base.input();
            Console.Write("Chuong trinh: ");
            program = Console.ReadLine();
            Console.Write("Nam: ");
            year = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            string baseinfo1 = base.ToString();
            return baseinfo1 + $"Program: {program}, Year: {year}";
        }
        public void changeprogram(string program)
        {
            Console.Write("Change Program: ");
            program = Console.ReadLine();
            this.program = program;
        }
    }
}
