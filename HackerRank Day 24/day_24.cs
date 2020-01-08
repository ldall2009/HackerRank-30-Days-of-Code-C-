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

namespace HackerRank_Day_24
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

        public static Node removeDuplicates(Node head){
      
            if (head == null){
                return null;
            }

            if (head.next == null){
                return head;
            }

            Node current = head;
            Node nextNode = head.next;
            bool endOfList = false;

            while (nextNode != null && !endOfList){

                // if the two nodes have the same data
                if (current.data == nextNode.data){

                    // while the nodes still have the same data
                    while (nextNode.next != null && current.data == nextNode.data){
                        nextNode = nextNode.next;
                    }

                    // if last node in list has current's data still
                    if (nextNode.next == null && current.data == nextNode.data) {
                        current.next = null;
                        endOfList = true; // at end of list
                    } else {

                        // if not at last node in list yet
                        current.next = nextNode;
                        current = nextNode;
                        nextNode = nextNode.next;
                    }

                // if the nodes do not have the same data
                } else {
                    current = current.next;
                    nextNode = nextNode.next;
                }

            }

            return head;
        }

        public static  Node insert(Node head,int data)
        {
            Node p=new Node(data);
		
		
            if(head==null)
                head=p;
            else if(head.next==null)
                head.next=p;
            else
            {
                Node start=head;
                while(start.next!=null)
                    start=start.next;
                    start.next=p;
			
                }
            return head;
        }

        public static void display(Node head)
        {
            Node start=head;
            while(start!=null)
            {
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
            head=removeDuplicates(head);
            display(head);
        }
    }
}
