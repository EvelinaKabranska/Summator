using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummatorAverage
{
    public static class SummatorAverage
    {
        public static double Average(double[] arr)
        {
            double sum = arr[0];
            double average = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
                average = sum / arr.Length;
            }
            return average;
        }
    }
}
