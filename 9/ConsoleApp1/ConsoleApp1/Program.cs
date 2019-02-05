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
            // if.... else switch .. case
            int num1 = 8;
            int num2 = 16;

            if (num1 > num2 && num1 ==8)
            {
                Console.WriteLine("num1 больше чем num2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} меньше чем {num2}");

            }
             else
            {
                Console.WriteLine($"{num1} ровно {num2}");
            }
            Console.WriteLine("Нажмите Y или N");
            string selction = Console.ReadLine(); 
            // break,goto case return, throw

            switch(selction)
            {
                case "Y":
                    Console.WriteLine("Вы нажали клавишу Y");
                    break;
                        ;
                case "N":
                    Console.WriteLine("Вы нажали клавишу N");
                    break;
                default:
                    Console.WriteLine("Вы наwжали неизвесную клавишу");
                    break;
                    
          }
            // Тернарный оператор ор1?ор2:op3;
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмине + или -");
            string selection2 = Console.ReadLine();

            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
 
  Console.ReadKey();

        }
    }
}
