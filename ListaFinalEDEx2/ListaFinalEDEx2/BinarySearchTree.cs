// Leonardo Vecchi Meirelles
// 12011ECP002

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFinalEDEx2
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
        }

        public Node InsertRecursive(Node current, int data)
        {
            if (current == null)
            {
                return new Node(data);
            }
            else if (data < current.data)
            {
                current.left = InsertRecursive(current.left, data);
            }
            else if (data > current.data)
            {
                current.right = InsertRecursive(current.right, data);
            }

            return current;
        }

        public void Remove(int data)
        {
            root = RemoveRecursive(root, data);
        }

        public Node RemoveRecursive(Node current, int data)
        {
            if (current == null)
            {
                return current;
            }
            else if (data < current.data)
            {
                current.left = RemoveRecursive(current.left, data);
            }
            else if (data > current.data)
            {
                current.right = RemoveRecursive(current.right, data);
            }
            else
            {
                if (current.left == null)
                {
                    return current.right;
                }
                else if (current.right == null)
                {
                    return current.left;
                }
                else
                {
                    current.data = MinValue(current.right);
                    current.right = RemoveRecursive(current.right, current.data);
                }
            }
            return current;
        }

        public int MinValue(Node root)
        {
            int minv = root.data;
            while (root.left != null)
            {
                minv = root.left.data;
                root = root.left;
            }
            return minv;
        }


        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }
        public void PrintTree()
        {
            PrintTreeHelper(root, 0);
        }

        private void PrintTreeHelper(Node node, int level)
        {
            if (node == null)
                return;

            PrintTreeHelper(node.right, level + 1);
            for (int i = 0; i < level; i++)
                Console.Write("    ");
            Console.WriteLine(node.data);
            PrintTreeHelper(node.left, level + 1);
        }

    }
}
