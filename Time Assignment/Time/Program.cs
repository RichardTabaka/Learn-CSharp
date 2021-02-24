using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:


            int hour = 12;
            int minute = 0;
            int second = 0;
            //Here I calculated the seconds per hour and minute from the input and added all three together
            int secondsSinceMidnight = (hour * 60 * 60) + (minute * 60) + (second);
            //I used the total seconds in a day (24*60*60) minus the seconds that had passed to calculate the seconds remaining
            int secondsToMidnight = ((24 * 60 * 60) - secondsSinceMidnight);
            //For the percent I multiplied by 100 to give a whole percentage instead of a decimal in my output(so 12 hrs would be 50 percent instead of .5)
            double percentOfDay = ((secondsSinceMidnight / (24.0 * 60 * 60))*100);
            //Here the program would print all 3 calculated values within one string that describes each value
            Console.WriteLine($"It has been {secondsSinceMidnight} seconds since Midnight. There are {secondsToMidnight} seconds to Midnight. {percentOfDay} percent of the day has passed.");

            //---------------------------------------------------------------------------------------------------------------

            //Question 2:

            //This is where I determined what type of variable to use for each number
            ushort a1 = 52130;
            sbyte b1 = -115; 
            int c1 = 4825932;
            byte d1 = 97; 
            short e1 = -10000;
            short f1 = 20000; 
            byte g1 = 224; 
            int h1 = 970700000;
            byte i1 = 112; 
            sbyte k1 = -44; 
            int l1 = -1000000; 
            short m1 = 1990;
            ulong n1 = 123456789123456789; 
            //I wasn't sure if I should go with long or ulong here being that they use the same amount of
            //memory and could both contain the number. I chose ulong because it was a positive number

            //---------------------------------------------------------------------------------------------------------------

            //Question 3:

            void numberJumbler(int inp) {
                int ans1;
                int ans2;
                int ans3;
                int ans4;

                if (inp <= 9999 && inp >= -9999) //This checks if the input is a 4 digit integer using the else below
                                                 //to warn of an invalid input
                {
                    //This section breaks the input(inp) into 4 separate numbers to allow the program to move
                    //the digits around or add them up
                    int d = inp % 10;
                    int c = (inp / 10) % 10;
                    int b = (inp / 100) % 10;
                    int a = (inp / 1000) % 10;

                    //This satisfies the first requirement of finding the sum of all the digits
                    ans1 = a + b + c + d;

                    //This section reverses the order of the digits by placing the last number in the thousands, the third as 100s and so on.
                    //It then prints the value to the console
                    ans2 = (d * 1000) + (c * 100) + (b * 10) + a;
                    Console.WriteLine(ans2);

                    //This uses the same logic as above to place them in dabc order
                    ans3 = (d * 1000) + (a * 100) + (b * 10) + c;

                    //Same as above but is used to swap the b and c position digits
                    ans4 = (a * 1000) + (c * 100) + (b * 10) + d;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            //This was where I tested my work
            numberJumbler(2011);
        }
    }
}
