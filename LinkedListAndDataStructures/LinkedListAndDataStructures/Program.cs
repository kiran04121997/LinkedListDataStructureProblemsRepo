using System;
using System.Collections.Generic;
using LinkedListAndDataStructures;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello welcome to Linked List Problem");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddNode(56);
            customLinkedList.AddNode(30);
            customLinkedList.AddNode(76);
            customLinkedList.AddNode(80);
            Console.ReadLine();
        }
    }
}
