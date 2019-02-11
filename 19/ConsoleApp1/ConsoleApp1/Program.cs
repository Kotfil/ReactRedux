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
<<<<<<< HEAD
            State state1 = new State();
            State.state2 = new State();

            state2.x = 1;
            state2.y = 2;

            state1 = state2; // state.x = 1 state1.y = 2

            state2.x = 5;

            Console.WriteLine(state1.x);
            Console.WriteLine(state2.x);
         

            Console.ReadKey();
        }
        static void Calculate(int t)
        {

            object x = 6;
            int y = 7;
            int z = y + t;
        }
    }
    struct State
    {

        public int x;
        public int y;
        public Country country;

    }
    class Country
    {
        public int x;
        public int y;
    }
}

=======
            Calculate(5);
            Console.ReadKey();
        }
        static void Calculate (int t )
        {
            int x = 6;
            int y = 7;
            int z = y + t;



        }

    }
}
>>>>>>> cf6037f249a7c5206d31d29e21419f956e53fcd3
