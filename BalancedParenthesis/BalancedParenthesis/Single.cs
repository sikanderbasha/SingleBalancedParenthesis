using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    internal class Single
    {
        public Stack stack = new Stack();
        public string express = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";

        public void Check()
        {
            char[] array = express.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(')
                {
                    stack.Push(array[i]);
                }
                if (array[i] == ')')
                {
                    if (stack.top.Equals('('))
                    {
                        stack.Pop();
                    }
                }

            }

            if (stack.IsEmpty().Equals(0))
            {
                Console.WriteLine("Balanced expression");
            }
            else
            {
                Console.WriteLine("Unbalanced expression");
            }

        }
    }
}
