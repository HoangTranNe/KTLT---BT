using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_4
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public void date() { }
        public void date(int d, int m,int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }
        public void setDate(int newd, int newm, int newy)
        {
            this.day = newd;
            this.month = newm;
            this.year = newy;
        }
        public int getDay()
        {
            while(day >=1 && day <=30)
            {
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
            }
            return day;
        }
        public void setDay(int newday)
        {
            this.day = newday;
        }
        public int getMonth()
        {
            while (month >= 1 && month <= 12)
            {
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
            }
            return month;
        }
        public void setMonth(int newmonth)
        {
            this.month = newmonth;
        }
        public int getYear()
        {
            while (year >= 1900 && year <= 9999)
            {
                this.year = year;
            }
            return year;
        }
        public void setYear(int newyear)
        {
            this.year = newyear;
        }
        public string tostring()
        {
            string s = "";
            s = ($"{day:00}/{month:00}/{year}");
            return s;
        }
    }
}
