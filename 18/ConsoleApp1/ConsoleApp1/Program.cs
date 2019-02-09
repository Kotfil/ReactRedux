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
            User tom = new User("Tom", 23);
            // tom.name = "Tom";
            //tom.age = 22;
            tom.Info();


            User bob = new User("Bob") { age = 26 };
            // tom.name = "Bob";
            //tom.age = 22;
            bob.Info();


            Console.ReadKey();
        }
    }
}
    