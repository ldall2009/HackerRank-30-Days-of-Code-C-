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

namespace HackerRank_Day_17
{
    class Calculator{
        public int power(int n, int p) {
            if (n < 0 || p < 0){
                throw new System.ArgumentException("n and p should be non-negative");
            }
            return Convert.ToInt32(Math.Pow(n, p));
        }
    }

    class Solution{
        static void Main(String[] args){
            Calculator myCalculator=new  Calculator();
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]); 
                try{
                    int ans=myCalculator.power(n,p);
                    Console.WriteLine(ans);
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);
                }
            }
        }
    }   
}
