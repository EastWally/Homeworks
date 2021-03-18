using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class LinkedList : ILinkedList
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        private int _count = 0;

        public int GetCount()
        {
            return _count;
        }

        public void AddNode(int value)
        {
            var newNode = new Node { Value = value, PrevNode = EndNode };
            if (EndNode != null)
                EndNode.NextNode = newNode;
            EndNode = newNode;
            if (StartNode == null)
                StartNode = newNode;
            _count++;
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
            _count++;
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
            _count--;
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
            _count--;
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
}
