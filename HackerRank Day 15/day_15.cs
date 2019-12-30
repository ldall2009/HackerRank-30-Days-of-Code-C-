﻿using System;
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

namespace HackerRank_Day_15
{

    class Node
    {
        public int data;
        public Node next;
        public Node(int d){
            data=d;
            next=null;
        }
		
    }

    class Solution {

        public static  Node insert(Node head,int data){
      
            if (head == null){
                head = new Node(data);
            } else {
                Node current = head;
                while (current.next != null){
                    current = current.next;
                }
                current.next = new Node(data);
            }
            return head;
        }

        public static void display(Node head){

            Node start=head;
            while(start!=null){
                Console.Write(start.data+" ");
                start=start.next;
            }
        }

        static void Main(String[] args) {
	
            Node head=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                head=insert(head,data);
            }
            display(head);
        }
    }

}
