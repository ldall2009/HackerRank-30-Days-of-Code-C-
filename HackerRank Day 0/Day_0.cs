using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HackerRank_Day_0
{
    class Day_0
    {
        static void Main(string[] args)
        {
            // EXTRA: Print a string literal asking the user to enter a string to be displayed
            Console.Write("Enter a string to be displayed: ");

            // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, inputString.
            inputString = Console.ReadLine();

            // Line of code that prints the contents of inputString to stdout.
            Console.WriteLine("The string you have entered is: " + inputString);
        }
    }
}
