using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_5
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public void author (string name, string email, char gender)
        {
            Console.WriteLine("name: ");
            name = Console.ReadLine();
            Console.WriteLine("email: ");
            email = Console.ReadLine();
            Console.WriteLine("Gender: ");
            gender = Char.Parse(Console.ReadLine());
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public char getGender()
        {
            return gender;
        }
        public string toString ()
        {
            string s = "";
            Console.Write($"Author[name = {name},email = {email}, gender = {gender}]");
            return s;
        }
    }
}
