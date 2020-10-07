using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Data_Structures
{
    class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            this.head = null;
        }

        // LIFO
        public void InsertFirst(T value)
        {
            var current = new Node<T>(value);
            if (this.head == null)
            {
                this.head = current;
            }
            else
            {
                var prev = this.head;
                this.head = current;
                this.head.Next = prev;
            }
        }

        // FIFO
        public void Append(T value)
        {
            var current = new Node<T>(value);
            if (this.head == null)
            {
                this.head = current;
            }
            else
            {
                var runner = this.head;
                while (runner != null)
                {
                    if (runner.Next == null)
                    {
                        runner.Next = current;
                        break;
                    }
                    runner = runner.Next;
                }

            }
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            var runner = this.head;
            while (runner != null)
            {
               
                sb.Append(runner.Value + " -> ");
                runner = runner.Next;
            }
            sb.Append("END\n");
            sb.Append("Head: " + this.head.Value);
            return sb.ToString();
        }
    }
}
