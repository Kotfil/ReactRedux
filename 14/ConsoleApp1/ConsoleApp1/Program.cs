using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Days //int
    {
        Monday = 1, //0
        Tuesday = 2, //1
        Wednesday = 4,//2
        Friday = 8,//3
        Saturday = 16,//4
        Sunday//5
    }
    class Program
    {
      enum Operation 
        {
            Add,
            Subtract,
            Multiply,
            Divide
     
        }
        static void ApplyOperation(double x, double y, Operation op)
        {
            double result = 0.0;
            switch (op)
            { //1
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Add:
                    result = x - y;
                    break;
                case Operation.Add:
                    result = x * y;
                    break;
                case Operation.Add:
                    result = x / y;
                    break;

            }
            Console.Write
        } 
            
            static void Main(string[] args)
        {
            Days day;
            day = Days.Friday;
            Console.WriteLine((int)day);
            Console.ReadKey();


       
            
            }
                
          
        }
    }
}
