using NUnit.Framework;
using Sortix.Sorting;

namespace SortixTests.InsertionSortTests
{
    public class InsertionSortInitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorTest()
        {
            var sortingAlgorithm = new InsertionSort();
            Assert.NotNull(sortingAlgorithm);
            Assert.Pass();
        }

        [Test]
        public void ConstructorTestAndSortShouldExecute()
        {
            var sortingAlgorithm = new InsertionSort();
            Assert.NotNull(sortingAlgorithm);
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sortingAlgorithm.Sort(array);
            Assert.Pass();
        }
    }
}