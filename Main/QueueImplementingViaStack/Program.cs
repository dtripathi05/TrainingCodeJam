using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementQueueUsing2Stack;

namespace QueueImplementingViaStack
{
    class Queue
    {
        static void Main(string[] args)
        {
            QueueViaStack queue = new QueueViaStack();
            while(true)
            {
                Console.WriteLine("1=Equeue  2=DeQueue  0=Exit  ");
                int elect = Convert.ToInt32(Console.ReadLine());

                if (elect == 1)
                {
                    queue.Equeue();
                }
                else if(elect == 2)
                {
                   queue.DeQueue();
                }
                else if(elect == 0)
                {
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
        }
    }
}
