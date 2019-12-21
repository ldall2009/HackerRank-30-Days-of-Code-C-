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

namespace HackerRank_Day_6
{
    class day_6
    {
    	static void printOutput(String[] strs) {

            for(int i = 0; i < strs.Length; i++){

            	//get even-index chars
            	for(int j = 0; j < strs[i].Length; j += 2){

                    Console.Write(strs[i][j]);
                }

            	Console.Write(" ");

            	//get odd-index chars
            	for(int k = 1; k < strs[i].Length; k += 2){

                    Console.Write(strs[i][k]);
            	}
                Console.WriteLine();
            }
        }

        static void Main(String[] args) {
        
            int testCases = Convert.ToInt32(Console.ReadLine());
            String[] strs = new String[testCases];

            for(int i = 0; i < testCases; i++){
                strs[i] = Console.ReadLine();
            }

            printOutput(strs);
        }
    }
}
