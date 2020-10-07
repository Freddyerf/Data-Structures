using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }

        public Node(T value, Node<T> node)
        {
            this.Value = value;
            this.Next = node;
        }

    }
}
