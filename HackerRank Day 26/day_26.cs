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

namespace HackerRank_Day_26
{
    class Solution {

        static int getLateFee(int[] returned, int[] expected){

            const int YEAR_LATE_FEE = 10000;

            // if it is turned in a calendar year before expected, no fee
            if (returned [2] < expected [2]){
                return 0;
            }

            // if the year is different, there is a fixed fine of 10000
            if (returned[2] > expected[2]){
                return YEAR_LATE_FEE;
            }

            // if the month is different, its 500 * num of months late
            if (returned[1] > expected[1]){
                return 500 * (returned[1] - expected[1]);
            
            }

            // if the day is different, its 15 * num of days late
            if (returned[0] > expected[0]){
                return 15 * (returned[0] - expected[0]);
            }
        
            return 0;
        }

        static void Main(String[] args) {

            const int ARRAY_SIZE = 3;

            int[] returned = new int[ARRAY_SIZE];
            int[] expected = new int[ARRAY_SIZE];

            // get returned date values
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            returned = Array.ConvertAll(values, int.Parse); // fails if the format is invalid

            // get expected date values
            input = Console.ReadLine();
            values = input.Split(' ');
            expected = Array.ConvertAll(values, int.Parse);

            Console.WriteLine(getLateFee(returned, expected));

        }
    }
}
