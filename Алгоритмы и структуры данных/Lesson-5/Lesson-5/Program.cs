using System;
using Task2;


namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = GenerateTree();
            tree.PrintTree();
            Console.Write("BFS: ");
            BFS.Run(tree);
            Console.Write("\nDFS: ");
            DFS.Run(tree);
            Console.ReadKey();
        }

        static Tree GenerateTree()
        {
            Tree tree = new Tree();
            tree.AddItem(5);
            tree.AddItem(10);
            tree.AddItem(8);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(2);
            tree.AddItem(1);
            return tree;
        }
    }
}
