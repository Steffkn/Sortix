using NUnit.Framework;
using Sortix.Sorting;
using System;

namespace SortixTests.SortingAlgorithmsTests
{
    public abstract class SortOfAType
    {
        public void AssertSorting<T>(T[] array, SortingAlgorithm sortingAlgorithm) where T : IComparable
        {
            Assert.NotNull(sortingAlgorithm);
            var testArray = array.Clone() as T[];
            sortingAlgorithm.Sort(array);
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
            Assert.Pass();
        }
    }
}
