using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Stack
    {
        public int[] stack = new int[10];
        public int top = -1;
        public void Push(int input)
        {
            if (top >= 9)
            {
                Console.WriteLine("Stack OverFlow");
            }
            else
            {
                top++;
                stack[top] = input;
            }
        }
        public int Pop()
        {

            if (top < 0)
            {
                return 0;
            }
            else
            {
                return stack[top--];
            }
        }
    }
}
