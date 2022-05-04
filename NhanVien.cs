using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class NhanVien
    {
        private string staffID;//mã nv
        private string name;//họ tên nv
        private double payRate;//Hệ số lương
        private double baseRate;
        //Mức Lương căn bản dùng chung cho toàn bộ nhân viên của công ty (thuộc tính static)

        public NhanVien()
        {
            staffID = "null";
            name = "null";
        }
        public NhanVien(string staffID, string name, double baseRate)
        {
            this.staffID = staffID;
            this.name = name;
            this.payRate = payRate;
        }
        public void SetBaseRate(double baseRate)
        {
            this.baseRate = baseRate;
        }
        public void input()
        {
            Console.Write("Nhap Ma NV: ");
            staffID = Console.ReadLine();
            Console.Write("Nhap Ho Ten NV: ");
            name = Console.ReadLine();
            while (payRate > 0)
            {
                Console.Write("Nhap he so luong: ");
                payRate = Convert.ToDouble(Console.ReadLine());
            }
        }
        public string toString()
        {
            string n = "";
            n = ($"Nhanvien = [MaNV = {staffID}, HoTen = {name}, HSLuong = {payRate}");
            return n;
        }
        public double Pay()
        {
            double Luong = 0;
            Luong = payRate * baseRate;
            Console.Write($"Luong cua nhan vien la: {Luong}");
            return Luong;
        }
    }