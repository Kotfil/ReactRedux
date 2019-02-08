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
            var tuple = (count:5, sum:10);
            Console.WriteLine(tuple.count);
            Console.WriteLine(tuple.sum);

            tuple.Item1 += 20;
            Console.WriteLine(tuple.Item1);

            Console.ReadKey();
        }
    }
}
