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
            int[] nums = new int[4]; //3
;
            try
            {
                nums[5] = 10;
                Console.WriteLine("end of try block");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
