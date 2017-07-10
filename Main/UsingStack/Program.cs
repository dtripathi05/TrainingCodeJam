using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace UsingStack
{
    class ImplementingStack
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            while (true)
            {
                Console.WriteLine("1=Push    2=Pop   0=Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Provide Input in Interger");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    stack.Push(userinput);
                }
                else if (choice == 2)
                {
                    int popData = stack.Pop();
                    if (popData == 0)
                    {
                        Console.WriteLine("Stack is UnderFlow");
                    }
                    else
                        Console.WriteLine(popData);
                }
                else if (choice == 0)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
