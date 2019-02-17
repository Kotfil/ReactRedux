using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            enumprogram bankday = new enumprogram();
            int num, n;
            data show = new data();
            accounts bank = new accounts();
            show.load();
            Console.Clear();
            show.showintro();
            Console.Write("\n\n\n\t\tBank Active days Are as Following");
            Console.Write("n\n\n\t\tNumber indicates that day is Active wheras 0 indicates 0 that day is Off ");
            bankday.showactivedays();

            do
            {
                Console.Write("\n\n\n\tMain Menu");
                Console.Write("n\t01. NEW ACCOUNT");
                Console.Write("\n\t02. DEPOSIT AMOUNT");

            
        
    

