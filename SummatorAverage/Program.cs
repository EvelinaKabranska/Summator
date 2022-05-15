using System;

namespace SummatorAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = SummatorAverage.Average(new double[] { 10, 20, 30 });
            Console.WriteLine(result);
        }
    }
}
