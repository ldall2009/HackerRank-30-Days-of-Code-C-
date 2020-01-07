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

namespace HackerRank_Day_23
{
    class Node{
        public Node left,right;
        public int data;
        public Node(int data){
            this.data=data;
            left=right=null;
        }
    }

    class Solution{

        static void levelOrder(Node root){
            // queue used as advised by the hint on this challenge
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node current = root;

            // while the queue had nodes in it
            while(queue.Count > 0) {
                current = queue.Dequeue();
                Console.Write(current.data + " ");

                if (current.left != null) {
                    queue.Enqueue(current.left);
                }
                if (current.right != null) {
                    queue.Enqueue(current.right);
                }

            }
        }

        static Node insert(Node root, int data){
            if(root==null){
                return new Node(data);
            }
            else{
                Node cur;
                if(data<=root.data){
                    cur=insert(root.left,data);
                    root.left=cur;
                }
                else{
                    cur=insert(root.right,data);
                    root.right=cur;
                }
            return root;
            }
        }

        static void Main(String[] args){
            Node root=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                root=insert(root,data);            
            }
            levelOrder(root);
        
        }
    }
}
