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
        public void AddItem(List list, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = list.first;
            list.first = new_node;
            count++;
        }
        public void AddItemLast(List list, int new_data)
        {

        }
        public int Length()
        {
            return count;
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
