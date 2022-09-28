using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            if (head==null)
            {
                head = newnode;
                Console.WriteLine("{0} new Node inserted into LinkedList", data);
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("{0} new Node inserted into LinkedList", newnode.data);
        }

        public void Display()
        {
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }

            }
        }
    }
}
