using System;
using NodeList;

namespace SortedLinkedList
{
    
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
