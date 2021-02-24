using System;

namespace Week_4_Assignment
{
    class Exercise_5_2
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine(Multadd(1.0, 2.0, 3.0));

            double a = Math.Sin(Math.PI);
            double b = 1 / 4;
            double c = (Math.Cos(Math.PI / 4) / 2);
            Console.WriteLine(Multadd(a, b, c));

            double a1 = Math.Log(10);
            double b1 = 1;
            double c1 = Math.Log(20);
            Console.WriteLine(Multadd(a1, b1, c1));

            Console.WriteLine(Yikes(2));

        }
        */
        static double Multadd(double a, double b, double c)
        {
            return a * b + c;
        }

        static double Yikes(double a)
        {
            double res;
            double b = Math.Exp(a * -1);
            double c = Math.Sqrt(1 - b);
            res = Multadd(a, b, c);
            return res;
        }

    }
}
