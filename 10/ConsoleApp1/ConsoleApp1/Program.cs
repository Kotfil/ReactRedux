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
            //for
            //while
            //do..while
            //foreach

            //if..else switch

            for(int i=0;i<9;i++) // счетчик; условие; изменение счетчика
            {
                Console.WriteLine($"{i} - {i * i}");
            }
            Console.ReadKey();
        }
    }
}
