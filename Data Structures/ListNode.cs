using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }

        public ListNode(T value, ListNode<T> next)
        {
            this.Value = value;
            this.Next = next;
        }

    }
}
