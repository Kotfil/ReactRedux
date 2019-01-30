using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator.Add(2, 3);
            Console.ReadKey();
        }
    }
class calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Сумма{x}и{y} равна {z}");
        }
    }

}
