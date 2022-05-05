using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        //jeden uzel spojoveho ceznamu
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        //nutne pro obousmerny
        public Node<T> Previous { get; set; }
    }
}
