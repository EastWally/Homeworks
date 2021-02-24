using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    public class LinkedList :ILinkedList
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }


        public int GetCount()
        {
            int count = 0;
            if (StartNode != null)
            {
                var node = StartNode;
                do
                {
                    node = node.NextNode;
                    count++;
                } while (node != null);
            }
            return count; 
        }

        public void AddNode(int value)
        {
            var newNode = new Node { Value = value, PrevNode = EndNode };
            if (EndNode != null)
                EndNode.NextNode = newNode;
            EndNode = newNode;
            if (StartNode == null)
                StartNode = newNode;
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == null)
                return;

            var nextNode = node.NextNode;
            var newNode = new Node { Value = value, NextNode = nextNode, PrevNode = node };
            node.NextNode = newNode;
            if (nextNode != null)
                nextNode.PrevNode = newNode;
            else
                EndNode = newNode;

        }

        public void RemoveNode(int index)
        {
            int currentIndex = 0;
            var currentNode = StartNode;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    RemoveNode(currentNode);
                    break;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
        }

        public void RemoveNode(Node node)
        {
            if (node == null)
                return;

            if (node == StartNode)
            {
                node.NextNode.PrevNode = null;
                StartNode = node.NextNode;
            }
            else if (node == EndNode)
            {
                node.PrevNode.NextNode = null;
                EndNode = node.PrevNode;
            }
            else if (node.NextNode != null)
            {
                node.PrevNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = node.PrevNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            var currentNode = StartNode;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }
    }


    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

}
