using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;

namespace SortixTests.SortingAlgorithmsTests
{
    public class SortOfDoubleType : SortOfAType
    {
        [Test]
        [Combinatorial]
        public void SortOfOrderedDoublesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedDoubles))] double[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOfOrderedDoublesWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedDoublesWithDuplicates))] double[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedDoublesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedDoubles))] double[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedDoublesWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedDoublesWithDuplicates))] double[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }
    }
}
