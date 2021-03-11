using System;
using System.Collections.Generic;
using System.Text;
using Task2;

namespace Lesson_5
{
    public class BFS
    {
        static public void Run(Tree tree)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(tree.GetRoot());
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node.LeftChild != null)
                    queue.Enqueue(node.LeftChild);
                if (node.RightChild != null)
                    queue.Enqueue(node.RightChild);

                Console.Write($" [{node.Value}] ");
            }
        }
    }
}
