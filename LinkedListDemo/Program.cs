﻿namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Computation of Linked List");
            LinkedList linkedlist = new LinkedList();
            linkedlist.AddLast(56);
            //linkedlist.AddLast(30);
            linkedlist.AddLast(70);
            linkedlist.Display();
            linkedlist.InsertAtPerticularPosition(30, 2);
            linkedlist.Display();
        }
    }
}