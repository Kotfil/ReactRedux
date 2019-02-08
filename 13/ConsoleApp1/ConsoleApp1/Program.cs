using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // f(n) = n!;5!=1*2*3*4*5=120 
        // Factorial(5) = 5* Factorial(4) = 5 * 4 * Factorial(3) ..=5 * 4 * 3 * 2 * 1 * Factorial(0);
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            // f(n) = f(n-1) + f(n-2)
            // 1,1,2,3,5,8,13,21...

            
            int x = Factorial(8); //21
            
            Console.WriteLine(x);
            Console.WriteLine(Factorial(4)); //24
            Console.WriteLine(Factorial(6)); //720
            Console.ReadKey();
        }
    }
}
