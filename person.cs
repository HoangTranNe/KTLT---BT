using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    class person
    {
        private string name;
        private int birthYear;
        private string address;

        public person() { }
        public person(string name, int birthYear, string address)
        {
            this.address = address;
            this.birthYear = birthYear;
            this.name = name;
        }
        public virtual void input()
        {
            Console.Write("Nhap ten cua nhan vien: ");
            name = Console.ReadLine();
            Console.Write("Nhap ngay sinh cua nhan vien: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi cua nhan vien: ");
            address = Console.ReadLine();
        }
        public int GetAge()
        {
            DateTime now = DateTime.Today;
            return now.Year - birthYear;
        }
        public override string ToString()
        {
            string s = "";
            s = $"Person[name:{this.name}, Age = {GetAge()}, Address = {this.address}";
            return s;
        }
    }
}
