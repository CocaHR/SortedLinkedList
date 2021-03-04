using System;

namespace SortedLinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node()
        {
            next = null;
        }
        public Node(int item, Node link=null)
        {
            data = item;
            next = link;
        }
    }
    class List
    {
        int count;
        Node first;
        public Node head;
        public List()
        {
            count = 0;
            first = null;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
