using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLLists
{
    /*
     Add two numbers represented by linked lists 
     */
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node()
        { }

        public Node(int data)
        {
            Data = data;

        }

    }

    class LinkedList
    {
        public Node head;
        public Node current;

        public LinkedList()
        {
            head = null;
            current = head;
        }

        public LinkedList(Node node)
        {
            this.head = node;
        }
        public LinkedList(int data)
        {
            head.Data = data;
        }
        public void AddToNode(int data)
        {
            Node addNode = new Node();
            addNode.Data = data;

            if (head == null)
                head = addNode;
            else
            {
                current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = addNode;
                current = addNode;
            }
        }

        public void DisplayList()
        {
            current = head;
            if (head == null)
                Console.WriteLine("Empty List");
            else
            {
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine("\n\n");

            }
        }

        public void Display(Node node)
        {
            if (node == null)
                Console.WriteLine("Empty List");
            else
            {
                current = node;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine("\n\n");
            }
        }

        public Node AddList(Node h1, Node h2)
        {
            Node c1 = h1, c2 = h2;
            Node resultNode = null;
            Node current = resultNode;
            int sum, carry = 0;
            int c1Data, c2Data;

            if (c1 == null && c2 == null)
                return (resultNode);

            if (c1 == null)
                return (c2);
            if (c2 == null)
                return (c1);

            while (c1 != null || c2 != null)
            {
                if (c1 == null)
                    c1Data = 0;
                else
                {
                    c1Data = c1.Data;
                    c1 = c1.Next;
                }

                if (c2 == null)
                    c2Data = 0;
                else
                {
                    c2Data = c2.Data;
                    c2 = c2.Next;
                }

                sum = c1Data + c2Data + carry;
                carry = 0;

                if (sum > 9)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }

                if (resultNode == null)
                {
                    current = new Node(sum);
                    resultNode = current;
                }
                else
                {
                    current.Next = new Node(sum);
                    current = current.Next;
                }
            }

            if (carry > 0)
                current.Next = new Node(carry);

            current.Next.Next = null;

            return (resultNode);

        }

    }


    class AddList
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.AddToNode(2);
            list1.AddToNode(6);
            list1.AddToNode(9);

            LinkedList list2 = new LinkedList();
            list2.AddToNode(3);
            list2.AddToNode(5);

            Console.WriteLine("First List:");
            list1.DisplayList();
            Console.WriteLine("Second List");
            list2.DisplayList();


            Node result = list1.AddList(list1.head, list2.head);

            Console.WriteLine("The result list is:");
            list1.Display(result);

            Console.ReadLine();

        }
    }
}
