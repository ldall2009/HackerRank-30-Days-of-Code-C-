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

namespace HackerRank_Day_5
{
    class day_5
    {
        static void Main(string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++){
                Console.WriteLine(n + " x " + i + " = " + (n*i));
            }
        }
    }
}
