using NUnit.Framework;

namespace SummatorAverageTests
{
    public class Tests
    {
        [Test]
        public void Test_Average_ThreePossitiveNumbers()
        {
            double actual = SummatorAverage.SummatorAverage.Average(new double[] {5,10,15 });
            Assert.That(actual == 10);
        }

        [Test]
        public void Test_Average_ThreeNegativeNumbers()
        {
            double actual = SummatorAverage.SummatorAverage.Average(new double[] { -5, -10, -15 });
            Assert.That(actual == -10);
        }

        [Test]
        public void Test_Average_ThreeBigNumbers()
        {
            double actual = SummatorAverage.SummatorAverage.Average(new double[] { 5000000, 10000000, 15000000 });
            Assert.That(actual == 10000000);
        }

        [Test]
        public void Test_Average_ThreeDoubleNumbers()
        {
            double actual = SummatorAverage.SummatorAverage.Average(new double[] { 0.5, 1.3, 1.2 });
            Assert.That(actual == 1);
        }
    }
}