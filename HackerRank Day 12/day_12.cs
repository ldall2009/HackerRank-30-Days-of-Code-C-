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

namespace HackerRank_Day_12
{

    class Person{
        protected string firstName;
        protected string lastName;
        protected int id;
	
        public Person(){}
        public Person(string firstName, string lastName, int identification){
                        this.firstName = firstName;
                        this.lastName = lastName;
                        this.id = identification;
        }
        public void printPerson(){
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
        }
    }

    class Student : Person{
        private int[] testScores;  
  
        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here

        public Student(string firstName, string lastName, int id, int[] scores){
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here

        public char Calculate(){
            int sum = 0;
            double average = 0.0;

            for (int i = 0; i < testScores.Length; i++){
                sum += testScores[i];
            }

            average = (sum) / testScores.Length;

            if (average >= 90.0) {
                return 'O';
            } else if (average >= 80.0) {
                return 'E';
            } else if (average >= 70.0) {
                return 'A';
            } else if (average >= 55.0) {
                return 'P';
            } else if (average >= 40.0) {
                return 'D';
            } else {
                return 'T';
            }
        }
    }

    class Solution {
        static void Main() {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for(int i = 0; i < numScores; i++){
                scores[i]= Convert.ToInt32(inputs[i]);
            } 
	  	
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

}
