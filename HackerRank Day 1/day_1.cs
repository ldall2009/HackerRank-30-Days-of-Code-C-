using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HackerRank_Day_1
{
    class day_1
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int secondInt;
            double secondDouble;
            string secondString;

            // Read and save an integer, double, and String to your variables.
            secondInt = int.Parse(Console.ReadLine());
            secondDouble = double.Parse(Console.ReadLine());
            secondString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + secondInt);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(String.Format("{0:0.0}", (d + secondDouble)));   //String.Format was used to have the resulting double only have the tenths place.

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + secondString);
            // The 's' variable above should be printed first.
        }
    }
}
