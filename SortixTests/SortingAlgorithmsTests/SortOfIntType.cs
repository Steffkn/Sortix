using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SortixTests.SortingAlgorithmsTests
{
    public class SortOfIntType
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Combinatorial]
        public void SortOfOrderedIntShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedIntegers))] int[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOfOrderedIntWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedIntegersWithDiplicates))] int[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedIntShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedIntegers))] int[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedIntWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedIntegersWithDiplicates))] int[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        public void AssertSorting(int[] array, SortingAlgorithm sortingAlgorithm)
        {
            Assert.NotNull(sortingAlgorithm);
            var testArray = array.Clone() as int[];
            sortingAlgorithm.Sort(array);
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
            Assert.Pass();
        }
    }
}
