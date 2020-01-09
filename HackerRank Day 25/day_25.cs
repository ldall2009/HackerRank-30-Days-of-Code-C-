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

namespace HackerRank_Day_25
{
    class Solution {

        public static String isPrime(int n) {

            if (n < 2){
                return "Not prime";
            }
            int sqrt = (int) Math.Sqrt(n);

            /** if any whole number above 1 and below or up to sqrt(n) 
            *  divides evenly into n, then n cannot be a prime number.
            */
            for (int i = 2; i <= sqrt; i++){
                if (n % i == 0){
                    return "Not prime";
                }

            }

            return "Prime";
        }

        static void Main(String[] args) {
        
            int testCaseNum = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[testCaseNum];

            for (int i = 0; i < array.Length; i++){
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++){
                Console.WriteLine(isPrime(array[i]));
            }
        }
    }
}
