using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student 老吳 =
                new Student
                {
                    name = "arthur",
                    email = "qq@gmail.com",
                    phone = "0912345678"
                };
            Console.WriteLine(老吳.name);
            Console.WriteLine(老吳.email);
            Console.WriteLine(老吳.phone);
        }
    }
}