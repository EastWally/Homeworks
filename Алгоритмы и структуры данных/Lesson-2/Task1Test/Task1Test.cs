using System;
using Xunit;
using Task1;
using System.Collections.Generic;

namespace Task1Test
{
    public class Task1Test
    {
        [Fact]
        public void GetCount_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();
            testedList.AddNode(0);
            // Act
            var result = testedList.GetCount();
            // Assert
            Assert.Equal(1, result);

            // Arrange            
            for (int i = 1; i < 10; i++)
            {
                testedList.AddNode(i);
            }
            // Act
            result = testedList.GetCount();
            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void AddNode_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();
            // Act
            testedList.AddNode(0);
            var result = testedList.EndNode.Value;
            // Assert
            Assert.Equal(0, result);

            // Act
            testedList.AddNode(5);
            result = testedList.EndNode.Value;
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void AddNodeAfter_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();
            testedList.AddNode(0);
            testedList.AddNode(1);
            // Act  Добавить пустой узел
            testedList.AddNodeAfter(null, 2);
            List<int> expected = new List<int>() { 0, 1 };
            List<int> result = new List<int>();
            Node node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Добавить узел в середину списка
            testedList.AddNodeAfter(testedList.StartNode, 3);
            expected = new List<int>() { 0, 3, 1 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Добавить узел в конец списка
            testedList.AddNodeAfter(testedList.EndNode, 5);
            expected = new List<int>() { 0, 3, 1, 5 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result); ;
        }

        [Fact]
        public void RemoveNodeByNode_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();
            for (int i = 0; i < 7; i++)            
                testedList.AddNode(i);
            
            // Act  Удалить пустой узел
            testedList.RemoveNode(null);

            List<int> expected = new List<int>() { 0, 1, 2, 3, 4, 5, 6};
            List<int> result = new List<int>();
            Node node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Удалить узел в середине списка
            testedList.RemoveNode(testedList.StartNode.NextNode);
            expected = new List<int>() { 0, 2, 3, 4, 5, 6 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Удалить узел в конце списка
            testedList.RemoveNode(testedList.EndNode);
            expected = new List<int>() { 0, 2, 3, 4, 5 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(5, testedList.EndNode.Value);

            // Act Удалить узел в начале списка
            testedList.RemoveNode(testedList.StartNode);
            expected = new List<int>() { 2, 3, 4, 5};
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(2, testedList.StartNode.Value);
        }

        [Fact]
        public void RemoveNodeByIndex_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();
            for (int i = 0; i < 7; i++)
                testedList.AddNode(i);

            // Act  Удалить пустой узел
            testedList.RemoveNode(null);

            List<int> expected = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            List<int> result = new List<int>();
            Node node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Удалить узел в середине списка
            testedList.RemoveNode(2);
            expected = new List<int>() { 0, 1, 3, 4, 5, 6 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);

            // Act Удалить узел в конце списка
            testedList.RemoveNode(5);
            expected = new List<int>() { 0, 1, 3, 4, 5 };
            result = new List<int>();
            node = testedList.StartNode;
            do
            {
                result.Add(node.Value);
                node = node.NextNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(5, testedList.EndNode.Value);

            // Act Удалить узел в начале списка
            testedList.RemoveNode(0);
            expected = new List<int>() { 1, 3, 4, 5 };
            result = new List<int>();
            node = testedList.EndNode;
            do
            {
                result.Insert(0, node.Value);
                node = node.PrevNode;
            }
            while (node != null);
            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(1, testedList.StartNode.Value);
        }

        [Fact]
        public void FindNode_Test()
        {
            // Arrange
            LinkedList testedList = new LinkedList();                     
            for (int i = 0; i < 10; i++)
            {
                testedList.AddNode(i);
            }
            // Act
            var result = testedList.FindNode(4);
            // Assert
            Assert.Equal(4, result.Value);

            // Act
            result = testedList.FindNode(0);
            // Assert
            Assert.Equal(0, result.Value);

            // Act
            result = testedList.FindNode(9);
            // Assert
            Assert.Equal(9, result.Value);

            // Act
            result = testedList.FindNode(10);
            // Assert
            Assert.Null(result);
        }
    }
}
