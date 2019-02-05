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
            // Операции сравнения
            // Логические операции
            int a = 10;
            int b = 4;
            bool c = a == b; // false

            bool d = a != b; // true 

            // < > <= >=
            bool f = a > b; // true 

            bool e = a < b; // false 

            bool g = a >= b; // true
            bool h = a <= b; // false]

            // | || & && ! ^ 
            bool x1 = (5 > 6) | (4 < 6); // false | true => true
            bool x2 = (5 > 6) || (4 > 6); // false | false => false

            bool x3 = (5 > 6) && (4 < 6); // false | true => false
            bool x4 = (5 > 6) && (4 > 6); // false | false => false
            bool x5 = (5 < 6) & (4 < 6) // true | true => true

                // результат отрицания (!)
                bool t = false;
            bool s = !t; //true

            bool x31 = (5 > 6) ^ (4 < 6); // false | true => true
            bool x41 = (5 < 6) ^ (4 < 6); // false | false => false


            Console.ReadKey();




        }
    }
}
