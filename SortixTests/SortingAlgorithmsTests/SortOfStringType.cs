using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;

namespace SortixTests.SortingAlgorithmsTests
{
    public class SortOfStringType : SortOfAType
    {
        [Test]
        [Combinatorial]
        public void SortOfOrderedStringsShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedStrings))] string[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOfOrderedStringsWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedStrings))] string[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedStringsShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedStrings))] string[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedStringsWithDuplicatesShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedStrings))] string[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }
    }
}
