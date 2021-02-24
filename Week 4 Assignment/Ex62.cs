using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment
{
    class Ex62
    {
        // Problem 1:
        // The program doesn't exit when it reaches 1.0 due to the inaccuracy of doubles in programming languages.
        // Floats/doubles aren't exact in the way they are calculated so without rounding your math using them will be wrong.
        // I would use decimals to be accurate in this math and not lose data.
        
        static void Main(string[] args)
        {
            decimal count = 0.0m;
            while (count != 1.0m)
            {
                count = count + 0.1m;
                Console.Write(count);
                Console.ReadLine();
            }
            DontPrint1();
        }

        // I did the problem both ways, printing 1.0 and stopping and not printing 1.0 before stopping.
        // Key differences are count being initialized as 0.1 and printing before adding.
        static void DontPrint1()
        {
            decimal count = 0.1m;
            while (count != 1.0m)
            {
                Console.Write(count);
                Console.ReadLine();
                count = count + 0.1m;
            }
        }
        
    }
}
