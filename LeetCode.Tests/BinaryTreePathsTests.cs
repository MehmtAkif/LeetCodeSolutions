using Tree;

namespace LeetCode.Tests
{
    public class BinaryTreePathsTests
    {
        private readonly BinaryTreePaths _binaryTreePaths = new BinaryTreePaths();

        [Fact]
        public void Test1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            IList<string> result = _binaryTreePaths.Solve(root);

            Assert.Equal(new List<string> { "1->2->5", "1->3" }, result);
        }

        [Fact]
        public void Test2()
        {
            TreeNode root = new TreeNode(1);

            IList<string> result = _binaryTreePaths.Solve(root);

            Assert.Equal(new List<string> { "1" }, result);
        }
    }
}