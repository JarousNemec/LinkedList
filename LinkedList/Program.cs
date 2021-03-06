using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //LinkedList<int> linkedList = new LinkedList<int>();
            // Node<int> node1 = new Node<int>() { Value = 10 };
            // Node<int> node2 = new Node<int>() { Value = 20 };
            // node1.Next = node2;
            // Console.WriteLine(node1.Value);
            // Console.WriteLine(node1.Next.Value);

            var customLinkedList = new CustomLinkedList<int>();
            customLinkedList.AddFirst(69);
            customLinkedList.AddLast(2);
            customLinkedList.AddLast(4);
            customLinkedList.AddLast(15);
            customLinkedList.AddLast(35);
            customLinkedList.AddLast(1);
            
            var customLinkedList2 = new CustomLinkedList<int>(){69,2,4,15,35,1};
            
            foreach (var node in customLinkedList)
            {
                Console.WriteLine(node);
            }
            
            Console.WriteLine("--------------------------");
            //customLinkedList.WriteFromLast();
            Console.WriteLine(customLinkedList.GetOnIndex(3));
            var l = new LinkedList<int>();
            l.AddFirst(4);
            l.AddFirst(9);
            Console.ReadKey();
        }
    }
}
