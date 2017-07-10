using System;

namespace TrailingZerosOfFactorial
{
    public class ZerosCount
    {
        public int Zeros = 0;
        public int temp = 0;
        public int TrailingZeros(int input)
        {
            for (int j = 1; j <= input; j++)
            {
                temp = j;
                if (temp % 5 == 0)
                {
                    Zeros++;
                    do
                    {
                        temp = temp / 5;
                        if (temp % 5 == 0)
                        {
                            Zeros++;
                        }
                    } while (temp % 5 == 0);
                }
            }
            return Zeros;
        }
    }
}

