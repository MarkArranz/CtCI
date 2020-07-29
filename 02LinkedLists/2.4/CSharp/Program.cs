using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Linked List
            var node = new Node(3);
            node.appendToTail(7);
            node.appendToTail(4);
            node.appendToTail(11);
            node.appendToTail(1);
            node.appendToTail(10);
            
            var test = AroundX(node, 0);
            test.print();
        }
        public static Node AroundX(Node node, int x) {
            Node head = null;
            Node mid = null;
            Node lessRunner = null;
            Node greaterRunner = null;
            
            // if (node == null)
            // {
            //     throw new Exception("Node is null.");
            // }

            while (node != null) {
                if (node.Data < x) {
                    // Init head if needed
                    if (head == null) {
                        head = node;
                        lessRunner = node;
                    }
                    else
                    {
                        lessRunner.Next = node;
                        lessRunner = node;
                    }
                }
                else
                {
                    if (mid == null) {
                        mid = node;
                        greaterRunner = node;
                    } 
                    else
                    {
                        greaterRunner.Next = node;
                        greaterRunner = node;
                    }
                }

                node = node.Next;
            }

            greaterRunner.Next = null;
            lessRunner.Next = mid;
            return head;
        }
    }
    class Node {

        public int Data { get; private set; }
        public Node Next { get; set; }

        public Node(int d) {
            Data = d;
            Next = null;
        }

        public void appendToTail(int d) {
            // Create a new node to add to the end.
            Node end = new Node(d);

            // Starting at this node (beginning).
            Node n = this;
            // Iterate through the nodes until you find one without a "next" value.
            while (n.Next != null) {
                n = n.Next;
            }
            // Set the current "last" node to point to the new "last" node.
            n.Next = end;
        }
        
        public void print() {
            var n = this;
            // Iterate through the nodes until you find one without a "next" value.
            while (n != null) {
                Console.WriteLine(n.Data);
                n = n.Next;
            }
        }
    }
}
