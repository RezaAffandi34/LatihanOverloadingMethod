using System;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return 1;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return 2;
        }

        public int FindMaximum(int number1, int number2)
        {
            return 3;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return 4;
        }
    }
}