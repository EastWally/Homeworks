using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Tree : ITree
    {
        private TreeNode root;

        public TreeNode GetRoot()
        {
            return root;
        }
        public void AddItem(int value)
        {
            TreeNode node = new TreeNode();
            node.Value = value;

            //Если дерево пустое, новый узел становится корнем.
            if (root == null)
                root = node;
            else
                AddItem(root, node);
        }

        /// <summary>
        /// Новое значение меньше корневого.В этом случае значение должно быть вставлено слева.Если слева уже стоит элемент, то повторяем эту же операцию, только в качестве корневого узла рассматриваем левый узел. Если слева нет элемента, то добавляем новый узел.
        /// Новое значение больше корневого.В этом случае новое значение должно быть вставлено справа. Если справа уже стоит элемент, то повторяем операцию, только в качестве корневого рассматриваем правый узел.Если справа узла нет, то вставляем новый узел.
        /// </summary>
        /// <param name="rootNode">Стартовый узел</param>
        /// <param name="node">Новый узел</param>
        private void AddItem(TreeNode rootNode, TreeNode node)
        {
            if (rootNode == null)
                rootNode = node;
            else if (rootNode.Value > node.Value)
            {
                if (rootNode.LeftChild == null)                
                    rootNode.LeftChild = node;                
                else
                    AddItem(rootNode.LeftChild, node);
            }
            else
            {
                if (rootNode.RightChild == null)                
                    rootNode.RightChild = node;                
                else
                    AddItem(rootNode.RightChild, node);
            }
        }

        public void RemoveItem(int value)
        {
            //При попытке удалить корень,
            if (value == root.Value)
            { throw new Exception("Can't remove root node"); }

            TreeNode node = root;
            TreeNode parentNode = null;

            while (node != null)
            {
                if (node.Value == value)
                {
                    RemoveNode(node, parentNode);
                    return;
                }
                else if (node.Value > value)
                {
                    parentNode = node;
                    node = node.LeftChild;
                }
                else
                {
                    parentNode = node;
                    node = node.RightChild;
                }
            }
        }

        /// <summary>
        /// Удалить узел
        /// </summary>
        /// <param name="node">Узел, который требуется удалить</param>
        /// <param name="parentNode">Родительский узел удаляемого узла</param>
        private void RemoveNode(TreeNode node, TreeNode parentNode)
        {
            //Если у узла нет наследников
            if (node.LeftChild == null && node.RightChild == null)
            {
                if (parentNode.LeftChild.Equals(node))
                    parentNode.LeftChild = null;
                else parentNode.RightChild = null;
            }//Если у узла есть только левый наследник
            else if (node.LeftChild != null && node.RightChild == null)
            {
                if (parentNode.LeftChild.Equals(node))
                    parentNode.LeftChild = node.LeftChild;
                else
                    parentNode.RightChild = node.LeftChild;
            }//Если у узла есть только правый насленик
            else if (node.RightChild != null && node.LeftChild == null)
            {
                if (parentNode.LeftChild.Equals(node))
                    parentNode.LeftChild = node.RightChild;
                else
                    parentNode.RightChild = node.RightChild;
            }//Если у узла есть оба наследника
            else
            {
                if (parentNode.LeftChild.Equals(node))
                {
                    parentNode.LeftChild = node.LeftChild;
                    parentNode.LeftChild.RightChild = node.RightChild;
                }
                else
                {
                    parentNode.RightChild = node.LeftChild;
                    parentNode.RightChild.RightChild = node.RightChild;
                }
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            TreeNode node = root;
            while (node != null)
            {
                if (node.Value == value)
                    return node;
                else if (node.Value > value)                
                    node = node.LeftChild;                
                else
                    node = node.RightChild;                    
            }
            return null;
        }

        public void PrintTree()
        {
            if (root == null) return;
            int spacing = 1;
            int topMargin = 2;
            int leftMargin = 2;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.Value.ToString() };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.LeftChild)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.LeftChild ?? next.RightChild;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.RightChild;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }
    }
}
