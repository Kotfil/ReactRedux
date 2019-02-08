using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static (string,int) GetValue((string,int) tuple,int x)
        {
            var result = (name: tuple.Item1, age: tuple.Item2 + x);
            return result;
        }
        static void Main(string[] args)
        {
            var tuple = GetValue("Tom, 25), 10);

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            Console.ReadKey();
        }
    }
}
