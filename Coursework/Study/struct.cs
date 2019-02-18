using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    struct data
    {
        private void intro()
        {
            Console.Write("\n\n\n\t\t\t BANK"); //1
            Console.Write("\n\n\t\tMANAGMENT");
            Console.Write("\n\n\t\t\t SYSTEM");
            Console.Write("\n\n\t\tMADE BY : Kotenko Filipp");
            Console.Write("\n\n\tUsing All Object Oriented Programing Tools");
        }
        public void showintro()
        {
            intro();
        }
        internal void load()
        {
            Console.Write("Loading");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}
