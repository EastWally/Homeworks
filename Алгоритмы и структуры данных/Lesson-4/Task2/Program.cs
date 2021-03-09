using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.AddItem(5);
            tree.AddItem(10);
            tree.AddItem(8);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(2);

            tree.PrintTree();

            Console.ReadKey();
        }
    }
}
