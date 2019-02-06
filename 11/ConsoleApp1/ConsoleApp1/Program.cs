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

            string s = Hello();
            int c = Sum();
            Console.WriteLine(c);
            Console.ReadKey();

        }

        static string Hello()
        {
            return "hello world!";
        }
        static int Sum()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }



        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        
        }
    }
