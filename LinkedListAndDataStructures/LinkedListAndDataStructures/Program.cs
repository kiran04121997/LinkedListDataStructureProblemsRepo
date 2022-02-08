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
            Program program = new Program();
            program.LinkedListCall();
            Console.ReadLine();
        }

        public void LinkedListCall()
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLastNode(56);
            customLinkedList.AddLastNode(30);
            customLinkedList.AddLastNode(40);
            customLinkedList.AddLastNode(70);
            customLinkedList.DisplayLinkedList();
            Console.WriteLine("-------------------------");
            int key = customLinkedList.SearchNode(40);
            customLinkedList.DeleteAtParticularPosition(key);
            customLinkedList.DisplayLinkedList();
            customLinkedList.Size();
        }
    }
}
