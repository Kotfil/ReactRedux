using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { name = "Tom", age = 22 };
            ChangeUser(user1);
            Console.WriteLine($"{user1.name} - {user1.age}");

            Console.ReadKey();
        }
        static void ChangeUser(User user)
        {
            user.name = "Bob";
            user.age = 33;
        }
    }
           struct  User
    {
        public int age;
        public string name;
        }
    class Person
    {
        public int age;
        public string name;
    }
  
    }







