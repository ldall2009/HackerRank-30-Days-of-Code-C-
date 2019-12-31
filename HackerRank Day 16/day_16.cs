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

namespace HackerRank_Day_16
{
    class day_16
    {
        static void Main(String[] args) {
            string S = Console.ReadLine();

            try {
                Console.WriteLine(Int32.Parse(S));

            } catch (FormatException e) {
                Console.WriteLine("Bad String");
            }
        }
    }    
}
