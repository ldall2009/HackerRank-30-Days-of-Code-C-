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

namespace HackerRank_Day_8
{
    class day_8
    {
        static void Main(String[] args) {

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            int numEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEntries; i++){
                string userInputPair = Console.ReadLine();
                string[] values = userInputPair.Split(' ');
                phoneBook.Add(values[0], int.Parse(values[1]));
            }

            string name;

            //while the user still has queries they would like to input
            while ((name = Console.ReadLine()) != null && name != ""){

                if (phoneBook.ContainsKey(name)){
                    int phoneNumber = phoneBook[name];
                    Console.WriteLine("{0}={1}", name, phoneNumber);

                } else {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
