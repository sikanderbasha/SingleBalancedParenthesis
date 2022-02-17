using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParanthesis
{
     class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;

        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Empty stack");
                return;
            }
            top = top.next;
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public int IsEmpty()
        {
            while (top != null)
            {              
                Pop();
            }
            return 0;
        }
    }
}
