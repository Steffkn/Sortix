using NUnit.Framework;
using Sortix.Shuffling;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortixTests.Shuffling
{
    public class ShufflingConstructorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShufflingConstructorTest1()
        {
            var shuffler = new Shuffler(new Random());
            Assert.Pass();
        }

        [Test]
        public void ShufflingConstructorTest2()
        {
            var shuffler = new Shuffler(new Random());
            double[] array = new double[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            shuffler.Shuffle(array);
            Assert.Pass();
        }
    }
}
