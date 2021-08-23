using System;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingStack
{
    class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }



    }
}
