using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSort
{
    class BinarySearchTree
    {
        private TreeNode root;
        private static int k;

        public BinarySearchTree()
        {
            root = null;
        }
        public void Inorder(int[] a)
        {
            k = 0;
            Inorder(root, a);
        }
        private void Inorder(TreeNode p, int[] a)
        {
            if (p == null)
                return;
            Inorder(p.lchild, a);
            a[k++] = p.info;
            Inorder(p.rchild, a);

        }
        public bool IsEmpty()
        {
            return root == null;
        }
        public void Insert(int x)
        {
            root = Insert(root, x);

        }
        private TreeNode Insert(TreeNode p, int x)
        {
            if (p == null)
                p = new TreeNode(x);
            else if(x<p.info)
                p.lchild = Insert(p.lchild, x);
            else if(x>p.info)
                p.rchild = Insert(p.rchild, x); 
            return p;   
        }
    }
}
