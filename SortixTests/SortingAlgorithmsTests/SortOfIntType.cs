﻿using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;

namespace SortixTests.SortingAlgorithmsTests
{
    public class SortOfIntType : SortOfAType
    {
        [SetUp]
        public void Setup() { }

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
    }
}
