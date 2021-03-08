using System;

namespace NodeList
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node()
        {
            next = null;
        }
        public Node(int item, Node link = null)
        {
            data = item;
            next = link;
        }
    }
    public class List
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
            if (!IsFull())
            {
                Node previous = null, following = first;
                while (following != null && following.data < item)
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
            while (temp != null)
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
            while (temp != null)
            {
                Console.Write($"{temp.data},");
                temp = temp.next;
            }
            Console.Write('\n');
        }
        public int Retrieve(int item)
        {
            Node temp = first;
            while (temp != null)
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
            if (IsEmpty())
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
    internal class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node()
        {
            next = null;
        }
        public Node(T item, Node<T> link = null)
        {
            data = item;
            next = link;
        }
    }   
    public class List<T>
    {
        private int count;
        private Node<T> first;

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
            Node<T> temp;
            temp = new Node<T>();
            if (temp == null) result = true;
            return result;
        }
        public void AddItem(T item)
        {
            if(IsFull())
                Console.WriteLine("List overflow");
            else
            {
                first = new Node<T>(item, first);
                count++;
            }
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
        public bool Search(T item)
        {
            Node<T> temp = first;
            while (temp != null)
            {
                if (Equals(item,temp.data))
                    return true;
                temp = temp.next;
            }
            return false;
        }
        public void PrintList()
        {
            Console.WriteLine("List content: ");
            if (count == 0) Console.Write("none");
            Node<T> temp = first;
            while (temp != null)
            {
                Console.Write($"{temp.data},");
                temp = temp.next;
            }
            Console.Write('\n');
        }
        public T Retrieve(T item)
        {
            Node<T> temp = first;
            while (temp != null)
            {
                if (Equals(temp.data, item))
                    return temp.data;
                temp = temp.next;
            }
            Console.WriteLine("Item was not found in list. Retrieving the first item in list");
            return first.data;
            
        }
        public void DeleteItem(T item)
        {
            T result;
            if (IsEmpty())
            {
                Console.WriteLine("List underflow");
            }
            Node<T> previous = null, following = first;
            while (following != null && !Equals(following.data, item))           //searching for item
            {
                previous = following;
                following = following.next;
            }
            if (previous == null && following != null && Equals(following.data, item))
            {
                result = following.data;
                first = first.next;
                count--;
            }
            else
                if (previous != null && following != null && Equals(following.data, item))
            {
                result = following.data;                      //deleting not 1st  node.
                previous.next = following.next;
                count--;
            }
            else
            {
                Console.WriteLine("Item was not found in list");
            }

        }
    }
    
}
