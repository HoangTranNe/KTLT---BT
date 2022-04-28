using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class rectangle
    {
        private double width;
        private double height;

        public void input()
        {
            Console.Write("Nhap chieu rong: ");
            this.width = int.Parse(Console.ReadLine());
            while (width < 0)
            {
                Console.Write("Vui long nhap lai: ");
                this.width = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap chieu dai: ");
            this.height = int.Parse(Console.ReadLine());
            while (height < 0)
            {
                Console.Write("Vui long nhap lai: ");
                this.height = int.Parse(Console.ReadLine());
            }
        }
        public string toString()
        {
            string s = "";
            s = ($"{width} / {height}");
            return s;
        }
        public double GetPerimeter()
        {
            return ((width + height) * 2);
        }
        public double GetArea()
        {
            return width * height;
        }
        public bool IsSameArea(rectangle rect)
        {
            if(rect.GetArea() == this.GetArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
