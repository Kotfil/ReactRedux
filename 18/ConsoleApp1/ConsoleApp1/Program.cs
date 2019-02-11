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
            //ref
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine($"x={x}");
            Console.WriteLine($"xRef={xRef}");

            xRef = 125;
            Console.WriteLine($"x={x}");

            Console.ReadKey();
        }
    }
}
