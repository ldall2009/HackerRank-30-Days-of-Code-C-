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

namespace HackerRank_Day_14
{

    class Difference {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements){
            this.elements = elements;
        }

        public void computeDifference(){
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            for (int i = 0; i < elements.Length; i++) {
                if (elements[i] > max){
                    max = elements[i];
                } if (elements[i] < min) {
                    min = elements[i];
                }
            }
            maximumDifference = Math.Abs(max - min);
        }
    } 

    class Solution {
        static void Main(string[] args) {
            Convert.ToInt32(Console.ReadLine());
        
            int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
            Difference d = new Difference(a);
        
            d.computeDifference();
        
            Console.Write(d.maximumDifference);
        }
    }

}
