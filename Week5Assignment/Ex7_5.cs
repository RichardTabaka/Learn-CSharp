using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Ex7_5
    {
        // Problem 1:
        // Use Main method to test combinations of various data types with + operator

        /*
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'c';
            int i = 1;
            string s = "Stringy string";
            Console.WriteLine(s + b);

            // Problem 4 char examples:
            char x = 'a';
            Console.WriteLine(x);

            x = Convert.ToChar(x + 1);
            Console.WriteLine(x);

            c = Convert.ToChar(c - 5);
            Console.WriteLine(c);

        }
        */
        
        // Problem 2:
        // Create a table describing the legality of the + operator between bools, chars, ints and strings. Is it addition or concatenation? Describe the data type returned.

        /*
         * Legality Key: L = Legal, N = Not Legal
         * Operation Type: A = addition, C = concatenation
         * Return Type: b = bool, c = char, i = int, s = string
         * 
                |bool   |char   |int    |string
         |bool  |N      |N      |N      |L,C,s
         |char  |N      |L,A,i  |L,A,i  |L,C,s
         |int   |N      |L,A,i  |L,A,i  |L,C,s
         |string|L,C,s  |L,C,s  |L,C,s  |L,C,s
         
         *
        */
        // Problem 3:
        // Give opinions on choices made for operation types and legality. Were some unavoidable? Did some seem
        // arbitrary? Do some seem problematic?

        // chars: In addition, because characters are assigned a number in ascii, adding them to an int would
        // logically create an int. That said it could be problematic if you were looking for concatenation
        // not addition. 
        // Having the ability to explicitly casting them back to chars seems both useful and logical
        // Concatenation with strings makes sense because concatenation returns a string.

        // ints: int + int = int is the only logical answer, int + bool shouldn't work because there are no
        // logical outcomes, int + string should be concatenation because it allows you to put ints in a string

        // strings: strings concatenating makes sense because they can't be added and concatenation could be a
        // useful way to display STRINGS of data from different data types.
        // I believe the addition of strings would be illogical because C# has data types for numbers that need
        // to be addeed. Strings should be used for data that won't need to be operated on like numbers. 

        // bools: Deciding which would override would be kind of arbitrary. Logical operators already exist in
        // C#(&&,||). Adding or concatenating bools with chars or ints doesn't make sense because the data is
        // incompatible.

        // Problem 4:
        // Normally x++ is exactly equivalent to x = x + 1. But if x is a char, x++ is legal but x = x + 1 causes
        // an error.

        //  If x is a char then x++ simply returns the next character. x + x = 1 would return an int so, unless
        // you also explicitly convert the output of x + x = 1 to a char, it wouldn't be able to assign it to a 
        // variable defined as a character. I've added code to Main() to show how x = x + 1 could be used legally
        // when modified to explicitly cast x as a char.
    }
}
