using System;

namespace SummatorSum
{
    public static class SummatorSum
    {
        public static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}