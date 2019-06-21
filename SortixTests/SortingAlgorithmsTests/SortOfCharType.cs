using NUnit.Framework;
using Sortix.Sorting;
using SortixTests.Data;

namespace SortixTests.SortingAlgorithmsTests
{
    public class SortOfcharType : SortOfAType
    {
        [Test]
        [Combinatorial]
        public void SortOfOrderedCharsShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.SortedCharacters))] char[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }

        [Test]
        [Combinatorial]
        public void SortOUnorderedCharsShouldExecuteAndReturnSortedArray(
            [ValueSource(typeof(DataContext), nameof(DataContext.UnorderedCharacters))] char[] array,
            [ValueSource(typeof(DataContext), nameof(DataContext.SortingAlgorithms))] SortingAlgorithm sortingAlgorithm)
        {
            this.AssertSorting(array, sortingAlgorithm);
        }
    }
}
