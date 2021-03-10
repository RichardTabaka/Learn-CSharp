using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    class Ex7_4
    {
        //EXERCISE 7.4:

        // Problem 1:
        // Here I encapsulated the code fragment that effectively did the same thing as this method within this method. This allowed it to operate on any string that is passed instead of just the assigned one.
        static int Count(string s)
        {
            int len = s.Length;

            int i = 0;
            int count = 0;

            while (i < len)
            {
                char c = s[i];

                if (c == '(')
                {
                    count = count +1;
                } else if ( c == ')')
                {
                    count = count - 1;
                }
                i = i + 1;
            }
            return count;
        }
        //-------------------------------------------------------------------------------
        // Problem 2:
        // 1-2 Sentence description of what the code does:

        // The method returns the count of '('s vs the count of ')'. It could be used to ensure no parentheses are opened without closing them or closed without an opening parenthesis.

        //-------------------------------------------------------------------------------
        // Problem 3:
        // What could be done to generalize the code more?

        // Not really sure what generalize means in this context but I'd go with
        // making the method take two more characters as arguments and then
        // compare the counts of them instead of two alerady specified characters.
        // This would allow the method to work with [], {}, quotation marks etc.

    }
}
