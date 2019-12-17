using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;


namespace HackerRank_Day_2
{
    class day_2
    {
        // Function to print the total cost of the check.
        static void solve(double mealCost, int tipPercent, int taxPercent)
        {

            double tip = mealCost * ((double) tipPercent / 100);
            double tax = mealCost * ((double) taxPercent / 100);
            int totalCost = Convert.ToInt32(mealCost + tip + tax);
            Console.WriteLine(totalCost);

        }

        static void Main(string[] args)
        {
            Console.Write("Enter the cost of the meal: ");
            double mealCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tip percentage: ");
            int tipPercent = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the tax percentage: ");
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            solve(mealCost, tipPercent, taxPercent);
        }
    }
}
