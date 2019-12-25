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

namespace HackerRank_Day_10
{
    class day_10
    {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int consecutive = 0;
            List<int> list = new List<int>();
        
            while (n > 0){
                list.Add(n % 2);
                n = n / 2;
            }

            for (int i = list.Count - 1; i >= 0; i--){
                if (list[i] == 1){
                    count++;
                } else {
                    count = 0;
                } if (count > consecutive) {
                    consecutive = count;
                }
            }
            Console.WriteLine(consecutive);
        }
    }
}
