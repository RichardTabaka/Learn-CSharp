using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    class Ex7_6
    {
    }
    public class MysteryClass
    {
        // What is the output of this program? Desribe what it does in 1 sentence.
        public static string Mystery(string s)
        {
            int i = s.Length - 1;
            string total = "";

            while (i >= 0)
            {
                char ch = s[i];
                Console.WriteLine(i + " " + ch);
                total = total + ch;
                i--;
            }
            return total;
        }

        /* The Main method is commented out to allow other classes to work.
         
        public static void Main(string[] args)
        {
            Console.WriteLine(Mystery("Allen"));
        }

        */

        /*
            OUTPUT:
            4 n
            3 e
            2 l
            1 l
            0 A
            nellA
            
            This method prints every character of a string with its position to the console, starting at the end
            and working to the beginning, then returning the reversed string.
         */
    }
}
