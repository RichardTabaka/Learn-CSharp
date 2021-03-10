using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    public class Ex7_10
    {
        // Problem 1:
        // Describe a process for checking whether a given word (string) is abecedarian, assuming that the word
        // contains only lower-case letters.
        
        //I would create a method that pulls the first and second char of the string then compares them.
        //Since, in C#, 'b' > 'a' == true and so on you could use that comparison of characters.

        public static bool IsAbecadarian(string s)
        {
            int j = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[j] < s[i])
                {
                    return false;
                }
                j++;
            }
            return true;
        }
    }
}
