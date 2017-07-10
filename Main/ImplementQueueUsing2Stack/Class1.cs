using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace ImplementQueueUsing2Stack
{
    public class QueueViaStack
    {
        Stack inside = new Stack();
        Stack outside = new Stack();
        public void Equeue()
        {
            Console.WriteLine("Enter the value to be stored =");
            int input = Convert.ToInt32(Console.ReadLine());
            inside.Push(input);

        }
        public void DeQueue()
        {
            if (outside.top < 0)
            {
                while (inside.top >= 0)
                {
                    outside.Push(inside.Pop());
                }
                int check = outside.Pop();
                if (check != 0)
                    Console.WriteLine(check);
                else
                    Console.WriteLine("Queue UnderFlow");
                while (outside.top >= 0)
                {
                    inside.Push(outside.Pop());

                }
            }
        }
    }
}
