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
        private int count;
        private Node first;
        
        public List()
        {
            count = 0;
            first = null;
        }
        bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            bool result = false;
            Node temp;
            temp = new Node();
            if (temp == null) result = true;
            return result;
        }
        public void AddItem(int item)
        {
            if(!IsFull())
            {
                Node previous = null, following = first;
                while(following!=null&&following.data<item)
                {
                    previous = following;
                    following = following.next;
                }
                if (previous == null)
                    first = new Node(item, first);
                else
                    previous.next = new Node(item, following);
                count++;
            }
            else
                Console.WriteLine("List overflow");
        }
        public void AddItemLast(int new_data)
        {

        }
        public int Length()
        {
            return count;
        }
        public void MakeEmpty()
        {
            count = 0;
            first = null;
        }
        public bool Search(int item)
        {
            Node temp = first;
            while(temp!=null)
            {
                if (temp.data == item)
                    return true;
                temp = temp.next;
            }
            return false;
        }
        public void PrintList()
        {
            Console.WriteLine("List content: ");
            if (count == 0) Console.Write("none");
            Node temp = first;
            while(temp!=null)
            {
                Console.Write($"{temp.data},");
                temp = temp.next;
            }
            Console.Write('\n');
        }
        public int Retrieve(int item)
        {
            Node temp = first;
            while(temp!=null)
            {
                if (temp.data == item)
                    return temp.data;
                temp = temp.next;
            }
            Console.WriteLine("Item was not found in list");
            return -10000;
        }
        public int DeleteItem(int item)
        {
            int result = 0;
            if(IsEmpty())
            {
                Console.WriteLine("List underflow");
                return -10000;
            }
            Node previous = null, following = first;
            while (following != null && following.data != item)           //searching for item
            {
                previous = following;
                following = following.next;
            }
            if (previous == null && following != null && following.data == item)
            {
                result = following.data;
                first = first.next;
                count--;
                return result;
            }
            else
                if (previous != null && following != null && following.data == item)
                {
                result = following.data;                      //deleting not 1st  node.
                previous.next = following.next;
                count--;
                return result;
                }
            else
            {
                Console.WriteLine("Item was not found in list");
                return -10000;
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List a = new List();
            if (!a.IsFull())
                a.AddItem(20);
            else
                Console.WriteLine("List full. Item cannot be added");
            a.PrintList();
            if (!a.IsFull())
                a.AddItem(30);
            else
                Console.WriteLine("List full. Item cannot be added");
            a.PrintList();
            if (!a.IsFull())
                a.AddItem(40);
            else
                Console.WriteLine("List full. Item cannot be added");
            a.PrintList();
            if (!a.IsFull())
                a.AddItem(15);
            else
                Console.WriteLine("List full. Item cannot be added");
            a.PrintList();
            if(a.Search(30))
                Console.WriteLine($"deleted item ={a.DeleteItem(30)}");
            else
                Console.WriteLine("Item not found. Could not be deleted");
            if (a.Search(70))
                Console.WriteLine($"deleted item ={a.DeleteItem(30)}");
            else
                Console.WriteLine("Item not found. Could not be deleted");
            Console.WriteLine($"deleted item ={a.DeleteItem(60)}");
            a.PrintList();
            Console.WriteLine($"retrieved item = {a.Retrieve(40)}");
            Console.WriteLine($"list size = {a.Length()}");

        }
    }
}
