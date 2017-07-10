using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrailingZerosOfFactorial;

namespace ZerosAfterFactorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            ZerosCount Zero = new ZerosCount();
            Console.WriteLine("Enter the number of your choice:");
            int input = Convert.ToInt32(Console.ReadLine());
            int zerosCount = Zero.TrailingZeros(input);
            Console.WriteLine("This is count of Trailing Zeros After Factorial of {0} = {1} ", input, zerosCount);
            Console.ReadKey();
        }
    }
}
