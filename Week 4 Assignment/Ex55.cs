using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment
{
    class Exercise_5_5
    {
        /*
        public static void Main()
        {
            Console.WriteLine(Prod(4, 6));
        }
        */
        // Prod takes two integers and recursively multiplies the first by every digit up to and including the second integer.
        // Given 1 and 4 it will multiply 1 * 1 * 2 * 3 * 4. Given 2 and 4 it would multiply 2 * 3 * 4
        // Given 5 and 6 it would multiply 4 * 5 * 6. It's like calculating part of a factorial
        // Below is my version of the method rewritten without temporary variables
        public static int Prod(int m, int n)
        {
            if ( m == n)
            {
                return n;
            } 
            else
            {
                return n * Prod(m, n - 1);
            }
        }
    }
}
