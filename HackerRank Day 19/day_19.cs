﻿using System;
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

namespace HackerRank_Day_19
{
    public interface AdvancedArithmetic{
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++){
                if (n % i == 0) {
                    sum += i;
                }
            }
            return sum;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
        }
    }
}
