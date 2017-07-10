using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueImplementation;

namespace ImplementingStackUsing2Queue
{
    public class StackViaQueue
    {
        Queue inside = new Queue();
        Queue outside = new Queue();
        public void Push()
        {
            Console.WriteLine("Enter the value to be Pushed =");
            int pushedValue = Convert.ToInt32(Console.ReadLine());
            inside.EnQueue(pushedValue);
        }
        public void Pop()
        {
            if (inside.Rear == -1)
            {
                Console.WriteLine("Empty Stack");
            }
            else
            {
                if (outside.Rear < 9)
                {
                    while (inside.Rear > 0)
                    {
                        outside.EnQueue(inside.DeQueue());

                    }
                    Console.WriteLine(inside.DeQueue());
                    while (outside.Rear >= 0)
                    {
                        inside.EnQueue(outside.DeQueue());
                    }
                }
            }
        }
    }
}
