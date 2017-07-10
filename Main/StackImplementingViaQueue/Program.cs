using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementingStackUsing2Queue;

namespace StackImplementingViaQueue
{
    class Stack
    {
        static void Main(string[] args)
        {
            StackViaQueue stack = new StackViaQueue();
            while (true)
            {
                Console.WriteLine("1=Push  2=Pop  0=Exit ");
                int elect = Convert.ToInt32(Console.ReadLine());

                if (elect == 1)
                {
                    stack.Push();
                }
                else if (elect == 2)
                {
                    stack.Pop();
                }
                else if (elect == 0)
                {
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
        }
    }
}
