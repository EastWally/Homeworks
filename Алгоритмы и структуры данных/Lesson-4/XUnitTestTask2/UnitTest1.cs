using System;
using Xunit;
using Task2;

namespace XUnitTestTask2
{
    public class UnitTest1
    {
        public Tree GenerateTree()
        {
            Tree tree = new Tree();
            tree.AddItem(5);
            tree.AddItem(10);
            tree.AddItem(8);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(2);
            return tree;
        }

        [Fact]
        public void Test_AddItem()
        {
            Tree tree = new Tree();
            tree.AddItem(5);
            tree.AddItem(10);
            tree.AddItem(8);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(2);

            NodeInfo[] expected = new NodeInfo[6];
            expected[0] = new NodeInfo() { Depth = 0, Node = new TreeNode(5) };            
            expected[1] = new NodeInfo() { Depth = 1, Node = new TreeNode(3) };
            expected[2] = new NodeInfo() { Depth = 1, Node = new TreeNode(10) };
            expected[3] = new NodeInfo() { Depth = 2, Node = new TreeNode(2) };
            expected[4] = new NodeInfo() { Depth = 2, Node = new TreeNode(4) };
            expected[5] = new NodeInfo() { Depth = 2, Node = new TreeNode(8) };
            var result = TreeHelper.GetTreeInLine(tree);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i].Depth, result[i].Depth);
                Assert.Equal(expected[i].Node.Value, result[i].Node.Value);
            }
         }

        [Fact]
        public void Test_GetRoot()
        {
            Tree tree = GenerateTree();

            int expected = 5;
            var result = tree.GetRoot().Value;
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Test_RemoveItem_Leaf()
        {
            Tree tree = GenerateTree();

            tree.RemoveItem(4);

            NodeInfo[] expected = new NodeInfo[5];
            expected[0] = new NodeInfo() { Depth = 0, Node = new TreeNode(5) };
            expected[1] = new NodeInfo() { Depth = 1, Node = new TreeNode(3) };
            expected[2] = new NodeInfo() { Depth = 1, Node = new TreeNode(10) };
            expected[3] = new NodeInfo() { Depth = 2, Node = new TreeNode(2) };
            expected[4] = new NodeInfo() { Depth = 2, Node = new TreeNode(8) };
            var result = TreeHelper.GetTreeInLine(tree);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i].Depth, result[i].Depth);
                Assert.Equal(expected[i].Node.Value, result[i].Node.Value);
            }
        }

        [Fact]
        public void Test_RemoveItem_Root()
        {
            Tree tree = GenerateTree();

            // Assert
            Assert.Throws<Exception>(() => tree.RemoveItem(5));
        }

        [Fact]
        public void Test_RemoveItem()
        {
            Tree tree = GenerateTree();

            tree.RemoveItem(3);

            NodeInfo[] expected = new NodeInfo[5];
            expected[0] = new NodeInfo() { Depth = 0, Node = new TreeNode(5) };
            expected[1] = new NodeInfo() { Depth = 1, Node = new TreeNode(2) };
            expected[2] = new NodeInfo() { Depth = 1, Node = new TreeNode(10) };
            expected[3] = new NodeInfo() { Depth = 2, Node = new TreeNode(4) };
            expected[4] = new NodeInfo() { Depth = 2, Node = new TreeNode(8) };
            var result = TreeHelper.GetTreeInLine(tree);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i].Depth, result[i].Depth);
                Assert.Equal(expected[i].Node.Value, result[i].Node.Value);
            }
        }

        [Fact]
        public void Test_GetNodeByValue()
        {
            Tree tree = GenerateTree();

            var result = tree.GetNodeByValue(3);

            Assert.Equal(3, result.Value);
            Assert.Equal(2, result.LeftChild.Value);
            Assert.Equal(4, result.RightChild.Value);
        }

    }
}
