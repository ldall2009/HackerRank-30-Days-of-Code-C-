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

namespace HackerRank_Day_11
{
    class day_11
    {
        static int getLargestHourglassSum(int[][] arr)
        {

            int max = Int32.MinValue;

            for (int i = 0; i < arr.GetLength(0) - 2; i++){

                /** can not use arr.GetLength(1) for the 2nd for loop exit condition,
                as internal arrays can have different sizes */

                for (int j = 0; j < arr[i].Length - 2; j++){

                    //get the addition of all cells that make the hourglass
                    int sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + 
                        arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] 
                        + arr[i + 2][j + 2]);
                        
                    if(max < sum){
                        max = sum;
                    }
                }
            }

        return max;
        }

        static void Main(string[] args) {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(getLargestHourglassSum(arr));
        }
    }
}
