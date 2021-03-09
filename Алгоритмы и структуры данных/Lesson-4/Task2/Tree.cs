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
            //Словарь значений узлов. Key - глубина, Value - значения узлов на этом уровне
            Dictionary<int, string> outputList = new Dictionary<int, string>();
            //Словарь дуг. Key - глубина, Value - дуги между узлами
            Dictionary<int, string> rowList = new Dictionary<int, string>();
            //Смещение вывода корневого узла
            int position = 60;
            int depth = 0;
            //Рекурсивный обход дерева и заполнение словарей
            PreOrderTravers(root, depth, position, ref outputList, ref rowList);
            //Вывод           
            foreach (var kv in outputList)
            {
                Console.WriteLine(kv.Value);
                Console.WriteLine(rowList[kv.Key]);
            }
        }

        /// <summary>
        /// Рекурсивный обход дерева и заполнение словарей
        /// </summary>
        /// <param name="root">Стартовый узел</param>
        /// <param name="depth">Текущая глубина</param>
        /// <param name="position">Смещение вывода строки</param>
        /// <param name="outputList">Словарь значений узлов</param>
        /// <param name="rowList">Словарь дуг</param>
        public void PreOrderTravers(TreeNode root, int depth, int position, ref Dictionary<int, string> outputList, ref Dictionary<int, string> rowList)
        {
            //Отступ между узлами на одном уровне
            int indent = 5;
            if (root != null)
            {
                //Если словарь дуг не содержит запись текущего уровня, добавить строку, заполненную пробелами до указанной позиции
                if (!rowList.ContainsKey(depth))
                    rowList.Add(depth, $"{("").PadRight(position, ' ')}");
                //Если узел имеет левого/правого потомка, добавить симоволы / \ и отступы к строке текущей глубины
                //Иначе добавить пробел и отступы к строке текущей глубины
                if (root.LeftChild != null)
                    rowList[depth] += $"{("/").PadRight(indent, ' ')}";
                else
                    rowList[depth] += $"{(" ").PadRight(indent, ' ')}";
                if (root.RightChild != null)
                    rowList[depth] += $"{("\\").PadRight(indent, ' ')}";
                else
                    rowList[depth] += $"{(" ").PadRight(indent, ' ')}";

                //Если словарь значений узлов не содержит запись текущего уровня, добавить строку, заполненную пробелами до указанной позиции
                if (!outputList.ContainsKey(depth))
                    outputList.Add(depth, $"{("").PadRight(position + 2, ' ')}");
                //Добавить значение узла к строке текущего уровня словаря значений узлов
                outputList[depth] += $"{(root.Value.ToString()).PadRight(indent + 1, ' ')}";

                //Увеличить глубину
                depth++;
                //Уменьшить левый сдвиг строк
                position -= 4;

                //Вызвать метод для левого и правого потомков
                PreOrderTravers(root.LeftChild, depth, position, ref outputList, ref rowList);
                PreOrderTravers(root.RightChild, depth, position, ref outputList, ref rowList);
            }
            //Если стартовый узел пуст, добавить проблемы в словари дуг и значений узлов
            else
            {
                if (!rowList.ContainsKey(depth))
                    rowList.Add(depth, $"{("").PadRight(position, ' ')}");
                

                if (!outputList.ContainsKey(depth))
                    outputList.Add(depth, $"{("").PadRight(position + 2, ' ')}");
                outputList[depth] += $"{(" ").PadRight(indent, ' ')}";
            }
        }
        
    }
}
