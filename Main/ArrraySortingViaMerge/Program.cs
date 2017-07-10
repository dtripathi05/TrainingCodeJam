using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrraySortingViaMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter the Number of Arrays==");
            int arrayCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Numberof Element in Arrays==");

            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[arrayCount][];
            int[] sortedArray = new int[arrayCount * arraySize];
            int count = 0;
            for (int i = 0; i < arrayCount; i++)
            {
                Console.WriteLine("Enter  {0}st Array Elements", i + 1);
                Console.WriteLine("-------------------------------------------------------");
                array[i] = new int[arraySize];
                for (int j = 0; j < arraySize; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                    sortedArray[count++] = array[i][j];
                }
            }
            program.MergeSort(sortedArray, 0, ((arrayCount * arraySize) - 1));
            foreach (int j in sortedArray)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
        public void Mergemethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, leftEnd, numElements, Post;
            leftEnd = (mid - 1);
            Post = left;
            numElements = (right - left + 1);
            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[Post++] = numbers[left++];
                else
                    temp[Post++] = numbers[mid++];
            }
            while (left <= leftEnd)
                temp[Post++] = numbers[left++];
            while (mid <= right)
                temp[Post++] = numbers[mid++];
            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        public void MergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);

                Mergemethod(numbers, left, (mid + 1), right);
            }
        }
    }
}

