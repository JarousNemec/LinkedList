using System;
using System.Collections;

namespace LinkedList
{
    public class CustomLinkedList<T> : IEnumerable
    {
        private Node<T> First { get; set; }
        private Node<T> Last { get; set; }

        public int Count { get; set; }

        public CustomLinkedList()
        {
            Count = 0;
        }

        public void AddFirst(T value)
        {
            //Novy pomocny uzel
            Node<T> node = new Node<T>() { Value = value };

            //pokud je seznam prazdny stane se novy prvek prvnim
            if (First == null)
            {
                First = node;
                Count++;
                return;
            }

            if (Last == null)
            {
                Last = First;
                Last.Previous = node;
                Last.Next = node;
                node.Next = Last;
                node.Previous = Last;
                First = node;
                Count++;
                return;
            }

            First.Previous = node;
            node.Next = First;
            node.Previous = Last;
            First = node;
            Last.Next = First;
            Count++;
        }

        public void AddLast(T value)
        {
            var node = new Node<T>()
            {
                Value = value,
            };
            if (First == null)
            {
                First = node;
                Count++;
                return;
            }

            if (Last == null)
            {
                Last = node;
                Last.Next = First;
                Last.Previous = First;
                First.Previous = Last;
                First.Next = Last;
                Count++;
                return;
            }

            Last.Next = node;
            node.Previous = Last;
            node.Next = First;
            Last = node;
            First.Previous = Last;
            Count++;
        }

        public IEnumerator GetEnumerator()
        {
            var node = First;
            for (var i = 0; i < Count; i++)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public void WriteFromLast()
        {
            var node = Last;
            for (var i = 0; i < Count; i++)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }

        public Node<T> GetFirst()
        {
            return First;
        }

        public Node<T> GetLast()
        {
            return Last;
        }

        public object GetOnIndex(int index)
        {
            if (index < Count)
            {
                var node = First;
                for (var i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                return node.Value;
            }

            return null;
        }

        public void Add(T value)
        {
            AddLast(value);
        }
    }
}