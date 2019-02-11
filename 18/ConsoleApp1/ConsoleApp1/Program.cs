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
<<<<<<< HEAD
            //ref
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine($"x={x}");
            Console.WriteLine($"xRef={xRef}");

            xRef = 125;
            Console.WriteLine($"x={x}");
=======
            User tom = new User("Tom", 23);
            // tom.name = "Tom";
            //tom.age = 22;
            tom.Info();


            User bob = new User("Bob") { age = 26 };
            // tom.name = "Bob";
            //tom.age = 22;
            bob.Info();

>>>>>>> cf6037f249a7c5206d31d29e21419f956e53fcd3

            Console.ReadKey();
        }
    }
}
<<<<<<< HEAD
=======
    
>>>>>>> cf6037f249a7c5206d31d29e21419f956e53fcd3
