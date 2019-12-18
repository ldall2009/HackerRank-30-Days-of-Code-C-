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

namespace HackerRank_Day_3
{
    class day_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 1 && N <= 100)
            {

                if (N % 2 == 1 || (N > 6 && N <= 20))
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }

            }
        }
    }
}
