using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment
{
    class Ex57
    {
        /*
        static void Main(string[] args)
        {
            string a = "This is a string";
            Console.WriteLine(First(a));
            Console.WriteLine(Rest(a));
            Console.WriteLine(Length(a));

            Console.WriteLine(ReverseString(a));

        }
        */
        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }
        // rest: returns a new string that contains all but the
        // first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }
        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }
        // Problem 3:
        public static void WriteString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        // Problem 4:
        public static void WriteBackward(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }
        // Problem 5:
        public static string ReverseString(string s)
        {
            string res = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                res += s[i];
            }
            return res;
        }
    }
}
