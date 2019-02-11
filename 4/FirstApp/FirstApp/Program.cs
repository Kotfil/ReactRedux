using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 инеремент и декремент
            // 2 Умножение и деление
            // 3 Сложениео и вычитания
            // 4 Комит

            int a = 3;
            int b = 5;
            int c = 40;
            int d = c-- - b * a;
            // (c--) = 40 | c=39
            // b*a =15
            // 40 - 15 = 25
            Console.WriteLine($"a={a} b={b} c={c} d={d}");
           

            Console.ReadKey();



        }
    }
}
