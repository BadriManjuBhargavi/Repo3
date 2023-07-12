using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise-1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.WriteLine("username");
            username = Console.ReadLine();
            Console.WriteLine("Password");
            password = Console.ReadLine();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please provide username and password");
            }
            else if (username == "admin" && password == "admin@1256@1256")
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
            Console.ReadKey();
        }
    }
}