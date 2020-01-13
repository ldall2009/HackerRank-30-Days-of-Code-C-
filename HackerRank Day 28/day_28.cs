using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank_Day_28
{
    class Solution {

        static void Main(string[] args) {

            int N = Convert.ToInt32(Console.ReadLine());

            List<string> names = new List<string>();
            Regex expression = new Regex("[a-z]+@gmail\\.com$");

            for (int NItr = 0; NItr < N; NItr++) {

                string[] firstNameEmailID = Console.ReadLine().Split(' ');
                string firstName = firstNameEmailID[0];
                string emailID = firstNameEmailID[1];

                if (expression.IsMatch(emailID)){
                    names.Add(firstName);
                }
            }

            names.Sort();
            names.ForEach(Console.WriteLine);
        }
    }
}
