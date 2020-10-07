using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class TreeNode<T> where T : IComparable
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode()
        {
            this.Left = null;
            this.Right = null;
            this.Value = default;
        }
        public TreeNode(T value)
        {
            this.Left = null;
            this.Right = null;
            this.Value = value;
        }
        public TreeNode(T value, TreeNode<T> left, TreeNode<T> right)
        {
            this.Left = left;
            this.Right = right;
            this.Value = value;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            TreeNode<T> otherNode = obj as TreeNode<T>;
            if (otherNode != null)
            {
                return this.Value.CompareTo(otherNode.Value);
            }
            else
            {
                throw new ArgumentException("Object is not comparable");
            }
            
        }
    }
}
