using System;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = GenerateGraph();
            Console.Write("DFS: ");
            Node.DFS(node);
            Console.Write("\nBFS: ");
            Node.BFS(node);
            Console.ReadKey();
        }

        static Node GenerateGraph()
        {
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            node1.Edges.Add(new Edge() { Node = node5, Weight = 1 });
            node1.Edges.Add(new Edge() { Node = node2, Weight = 1 });  
            node2.Edges.Add(new Edge() { Node = node6, Weight = 1 });
            node2.Edges.Add(new Edge() { Node = node3, Weight = 1 });
            node2.Edges.Add(new Edge() { Node = node1, Weight = 1 });
            node3.Edges.Add(new Edge() { Node = node6, Weight = 1 });
            node3.Edges.Add(new Edge() { Node = node4, Weight = 1 });
            node3.Edges.Add(new Edge() { Node = node2, Weight = 1 });
            node4.Edges.Add(new Edge() { Node = node5, Weight = 1 });
            node4.Edges.Add(new Edge() { Node = node3, Weight = 1 });
            node5.Edges.Add(new Edge() { Node = node6, Weight = 1 });
            node5.Edges.Add(new Edge() { Node = node4, Weight = 1 });
            node5.Edges.Add(new Edge() { Node = node1, Weight = 1 });
            node6.Edges.Add(new Edge() { Node = node5, Weight = 1 });
            node6.Edges.Add(new Edge() { Node = node3, Weight = 1 });
            node6.Edges.Add(new Edge() { Node = node2, Weight = 1 });
            return node1;
        }
    }
}
