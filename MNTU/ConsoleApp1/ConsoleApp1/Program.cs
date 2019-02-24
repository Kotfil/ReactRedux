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
            //method Parse
            Console.WriteLine("Введіть ціле");
            string strdata = Console.ReadLine();
            int intdata = int.Parse(strdata);
            Console.WriteLine("Введіть число з дробовою частиною і порядком");
            strdata = Console.ReadLine();
            double doubdata = double.Parse(strdata);
            Console.WriteLine("intdata = {0}; doubdata = {1}",
               intdata, doubdata);
            Console.ReadKey();

        }
    }
}
