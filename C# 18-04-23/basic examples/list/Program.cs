using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace list
{
    class program
    {
        class LinkListNode
        {
            public int data;
            public LinkListNode next;

            public LinkListNode(int y)
            {
                data = y;
                next = null;
            }
        }
        class List
        {
            int count;
            LinkListNode head;

            public List()
            {
                head = null;
                count = 0;
            }
            public void AddNodeToFront(int data)
            {
                LinkListNode node = new LinkListNode(data);

                node.next = head;
                head = node;
                count++;
            }
            public void RemoveNodeFromFront()
            {
                LinkListNode temp = head.next;
                head=temp;
            }
            public void PrintList()
            {
                LinkListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }
        static void Main(string[] args)
        {
            List Linkedlist = new List();
            Linkedlist.AddNodeToFront(5);
            Linkedlist.AddNodeToFront(9);
            Linkedlist.AddNodeToFront(3);
            Linkedlist.AddNodeToFront(7);
            Linkedlist.AddNodeToFront(8);

            Linkedlist.PrintList();
            Console.WriteLine("Deleted ");
            Linkedlist.RemoveNodeFromFront();

            Linkedlist.PrintList() ;
        }
    }
}

