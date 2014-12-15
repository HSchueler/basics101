using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Sequence up to 15 characters
            int curfib = 1;
            int oldfib = 0;  //init variables
            int temp = 0;

            Console.WriteLine(oldfib);
            Console.WriteLine(curfib);

            for (int i = 0; i < 13; i++)
            {
                temp = curfib;
                curfib = curfib + oldfib; //fibonacci calculation
                oldfib = temp;

                Console.WriteLine(curfib);
            }

            Console.ReadKey(); //Use readkey so the program doesn't auto exit after completion

        }
    }
}
