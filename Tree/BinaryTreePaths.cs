// ==============================
// #257 - Binary Tree Paths
// Zorluk: Easy
// Konu: Tree, DFS
// Tarih: 04.05.2026
// ==============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTreePaths
    {
        public IList<string> Solve(TreeNode root)
        {
            List<string> result = new List<string>();
            DFS(root, "", result);
            return result;
        }

        void DFS(TreeNode node, string path, List<string> result)
        {
            if (node == null) return;

            if (node.left == null && node.right == null)
            {
                result.Add(path + node.val);
                return;
            }

            DFS(node.left, path + node.val + "->", result);
            DFS(node.right, path + node.val + "->", result);
        }
    }
}