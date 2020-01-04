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

namespace HackerRank_Day_20
{
    class Solution {

        static void swap(ref int i, ref int j) {
            int temp = i;
            i = j;
            j = temp;
        }
    
        static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);

            int totalSwaps = 0;

            // Bubble Sort
            for (int i = 0; i < n; i++) {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;
    
                for (int j = 0; j < n - 1; j++) {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1]) {
                        // pass by reference to swap method
                        swap(ref a[j], ref a[j + 1]);
                        numberOfSwaps++;
                        totalSwaps++;
                    }
                }
    
                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0) {
                    break;
                }
            }

            Console.WriteLine("Array is sorted in {0} swaps."
                        + "\nFirst Element: {1}"
                        + "\nLast Element: {2}", totalSwaps, a[0], a[n-1]);
        }
    }
}
