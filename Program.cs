using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(8);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(9);
            binaryTree.Add(6);

            foreach (var item in binaryTree.Preorder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPreorder ↑");

            foreach (var item in binaryTree.Postorder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPostorder ↑");

            foreach (var item in binaryTree.Inorder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nInorder ↑");

            Console.ReadLine();
        }
    }
}
