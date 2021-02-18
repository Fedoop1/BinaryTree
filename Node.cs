using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T> : IComparable, IComparable<T>
        where T : IComparable, IComparable<T>
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public void Add(T data)
        {
            Node<T> item = new Node<T>(data);

            if(item.Data.CompareTo(Data) == -1)
            {
                if(Left == null)
                {
                    Left = item;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = item;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item.Data);
            }
            else
            {
                throw new ArgumentException("Uncompletable type");
            }
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
