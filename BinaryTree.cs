using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T> where T : IComparable, IComparable<T>
    {
        Node<T> Root { get; set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if(Root == null)
            {
                Node<T> item = new Node<T>(data);
                Root = item;
                return;
            }

            Root.Add(data);
        }
        public List<T> Preorder()
        {
            if(Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);

        }
        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);

        }
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);

        }
        private List<T> Preorder(Node<T> Node)
        {
            List<T> preorder = new List<T>();

            if(Node != null)
            {
                preorder.Add(Node.Data);

                if (Node.Left != null)
                {
                    preorder.AddRange(Preorder(Node.Left));
                }

                if (Node.Right != null)
                {
                    preorder.AddRange(Preorder(Node.Right));
                }
            }

            return preorder;
        }
        private List<T> Postorder(Node<T> Node)
        {
            List<T> postorder = new List<T>();

            if (Node != null)
            {
                if (Node.Left != null)
                {
                    postorder.AddRange(Postorder(Node.Left));
                }

                if (Node.Right !=  null)
                {
                    postorder.AddRange(Postorder(Node.Right));
                }

                postorder.Add(Node.Data);
            }

            return postorder;
        }
        private List<T> Inorder(Node<T> Node)
        {
            List<T> inorder = new List<T>();

            if (Node != null)
            {
                if (Node.Left != null)
                {
                    inorder.AddRange(Inorder(Node.Left));
                }

                inorder.Add(Node.Data);

                if (Node.Right != null)
                {
                    inorder.AddRange(Inorder(Node.Right));
                }

                
            }

            return inorder;
        }
    }
}
