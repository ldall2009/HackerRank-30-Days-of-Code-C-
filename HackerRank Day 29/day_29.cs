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

namespace HackerRank_Day_29
{
    class Solution {

        static int ComputeMax(int n, int k){

            int[] arr = new int[n];
            int max = 0;
            int andVal = 0;

            // initialize array content
            for (int i = 0; i < arr.Length; i++){
                arr[i] = i + 1;
            }

            for (int i = 0; i < arr.Length - 1; i++){
                for (int j = i + 1; j < arr.Length; j++){
                    andVal = arr[i] & arr[j];
                    if (andVal < k && andVal > max){
                        max = andVal;
                    }
                }
            }

            return max;
        }

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++) {
                string[] nk = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                Console.WriteLine(ComputeMax(n, k));
            }
       
        }
    }
}
