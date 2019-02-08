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
            try
            {
                int a = 33;
                int c = 600;
                byte b = checked((byte)(a + c));
                Console.WriteLine(b);

  }
            catch(OverflowException)
            {
                Console.WriteLine("недопустимый диапазон");
            }
           
       
        }
    }
}
