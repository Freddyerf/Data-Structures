using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class TreeNode<T>
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
    }
}
