using System;
using System.Collections.Generic;
using System.Text;
using Task2;

namespace Lesson_5
{
    public class DFS
    {
        static public void Run(Tree tree)
        {
            Stack<TreeNode> queue = new Stack<TreeNode>();
            queue.Push(tree.GetRoot());
            while (queue.Count != 0)
            {
                var node = queue.Pop();
                if (node.LeftChild != null)
                    queue.Push(node.LeftChild);
                if (node.RightChild != null)
                    queue.Push(node.RightChild);

                Console.Write($" [{node.Value}] ");
            }
        }
    }
}
