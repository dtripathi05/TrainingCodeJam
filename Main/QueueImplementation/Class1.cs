using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class Queue
    {


        public int[] queue = new int[10];
        public int Rear = -1;
        public void EnQueue(int input)
        {
            //if (Rear == 9)
            //{
            //    Console.WriteLine("Queue is OverFlow ");
            //}
            if (Rear < 9)
            {
                Rear++;
                if (Rear == 0)
                {
                    queue[Rear] = input;
                }
                else
                {
                    for (int index = Rear; index > 0; index--)
                    {
                        queue[index] = queue[index - 1];
                    }
                    queue[0] = input;
                }
            }
        }

        public int GetRear()
        {
            return Rear;
        }

        public int DeQueue()
        {
            if (Rear == -1)
                return 0;
            else
                return queue[Rear--];
        }

    }
}

