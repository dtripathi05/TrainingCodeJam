using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueImplementation;

namespace UsingQueue
{
    class ImplementingQueue
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            while (true)
            {
                Console.WriteLine("1=Enqueue    2=DeQueue   0=Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    if (queue.GetRear() == 9)
                    {
                        Console.WriteLine("Queue is OverFlow ");
                    }
                    else
                    {
                        Console.WriteLine("Provide Input in Integer");
                        int userinput = Convert.ToInt32(Console.ReadLine());
                        queue.EnQueue(userinput);
                    }
                }
                else if (choice == 2)
                {
                    int dequeueData = queue.DeQueue();
                    if (dequeueData == 0)
                    {
                        Console.WriteLine("Queue is UnderFlow");
                    }
                    else
                        Console.WriteLine(dequeueData);
                }
                else if (choice == 0)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
