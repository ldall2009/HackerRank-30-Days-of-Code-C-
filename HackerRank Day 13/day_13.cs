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

namespace HackerRank_Day_13
{

    abstract class Book
    {
    
        protected String title;
        protected  String author;
    
        public Book(String t,String a){
            title=t;
            author=a;
        }
        public abstract void display();


    }

    //Write MyBook class

    class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price) : base(title, author){
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", title, author, price);
        }

    }

    class Solution {
        static void Main(String[] args) {
            String title=Console.ReadLine();
            String author=Console.ReadLine();
            int price=Int32.Parse(Console.ReadLine());
            Book new_novel=new MyBook(title,author,price);
            new_novel.display();
        }

    }

}
