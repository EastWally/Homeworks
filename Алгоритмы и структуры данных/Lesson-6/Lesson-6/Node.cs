using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    public class Node
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; }
        public bool visited = false;

        public Node()
        {
            Edges = new List<Edge>();
        }

        public static void DFS(Node startNode)
        {
            startNode.visited = true;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(startNode);
            while (stack.Count != 0)
            {
                Node node = stack.Pop();
                Console.Write($" [{node.Value}] ");
                foreach (var link in node.Edges)
                {
                    if (!link.Node.visited)
                    {
                        link.Node.visited = true;
                        stack.Push(link.Node);
                    }
                }
            }
            ClearVisited(startNode);
        }

        public static void BFS(Node startNode)
        {
            startNode.visited = true;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();
                Console.Write($" [{node.Value}] ");
                foreach (var link in node.Edges)
                {
                    if (!link.Node.visited)
                    {
                        link.Node.visited = true;
                        queue.Enqueue(link.Node);
                    }
                }
            }
            ClearVisited(startNode);
        }

        //Очистка признака посещения узла в графе
        static void ClearVisited(Node startNode)
        {
            startNode.visited = false;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(startNode);
            while (stack.Count != 0)
            {
                Node node = stack.Pop();
                foreach (var link in node.Edges)
                {
                    if (link.Node.visited)
                    {
                        link.Node.visited = false;
                        stack.Push(link.Node);
                    }
                }
            }
        }
    }    
}
