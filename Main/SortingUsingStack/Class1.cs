using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace SortingUsingStack
{
    public class Sorting
    {
        public void Sort()
        {
            int[] array = new int[10];
            Console.WriteLine("Enter 10 values of array");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Stack stackObj = new Stack();
            int d;
            for (int y = 0; y < 10; y++)
            {
                if (array[0] > array[1])
                {
                    stackObj.Push(array[0]);
                    array[0] = array[1];
                }
                else
                {
                    stackObj.Push(array[1]);
                    array[1] = array[0];
                }
                for (d = 2; d < 10 - y; d++)
                {
                    if (stackObj.stack[stackObj.top] > array[d])
                    {
                        array[d - 1] = array[d];
                    }
                    else
                    {
                        array[d - 1] = stackObj.Pop();
                        stackObj.Push(array[d]);
                    }
                }
                array[d - 1] = stackObj.Pop();

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.ReadKey();
        }
    }
}
