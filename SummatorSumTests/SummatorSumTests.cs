using NUnit.Framework;
using System;

namespace SummatorSumTests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            double actual = SummatorSum.SummatorSum.Sum(new double[] {2,3});
            Assert.That(actual==5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            double actual = SummatorSum.SummatorSum.Sum(new double[] { -7, -3 });
            Assert.That(actual == -10);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            double actual = SummatorSum.SummatorSum.Sum(new double[] {});
            Assert.That(actual==0);
        }

        [Test]
        public void Test_Sum_BigNumbers()
        {
            double actual = SummatorSum.SummatorSum.Sum(new double[] { 2000000, 3000000 });
            Assert.That(actual == 5000000);
        }

        [Test]
        public void Test_Sum_NumbersDoubleType()
        {
            double actual = SummatorSum.SummatorSum.Sum(new double[] { 2.8, 3.5 });
            Assert.That(actual == 6.3);
        }
    }
}