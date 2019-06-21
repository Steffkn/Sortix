using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;
using System;

namespace SortingAlgorithmsTests
{
    public class SortingAlgorithmsInitTests
    {
        [Test]
        [Sequential]
        public void InitConstructorTests(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            Assert.NotNull(sortingAlgorithm);
            sortingAlgorithm.Sort(DataContext.SimpleArray);
            Assert.Pass();
        }
    }
}