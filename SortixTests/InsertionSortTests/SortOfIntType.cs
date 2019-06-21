using NUnit.Framework;
using Sortix.Sorting;

namespace SortixTests.InsertionSortTests
{
    public class SortOfIntType
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Sequential]
        public void SortOfOrderedIntShouldExecuteAndReturnSortedArray(
            [Values(
            new int[] { -45, -35, -31, -24, -11, -9, -7, -1, 0, 6, 8, 13, 15, 19, 25, 29, 40, 41, 42, 49 },
            new int[] { -46, -35, -31, -29, -28, -27, -15, -14, -10, -7, -1, 2, 7, 8, 15, 20, 21, 25, 34, 47 },
            new int[] { -37, -30, -26, -22, -15, -5, -4, -3, 15, 16, 18, 23, 28, 30, 36, 38, 45, 48, 49, 50 }
            )] int[] array)
        {
            var sortingAlgorithm = new InsertionSort();
            var testArray = array.Clone() as int[];
            sortingAlgorithm.Sort(array);
            Assert.Pass();
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
        }

        [Test]
        [Sequential]
        public void SortOfOrderedIntWithDuplicatesShouldExecuteAndReturnSortedArray(
            [Values(
            new int[] { -45, -35, -31, -24, -11, -9, -35, -31, -24, -11, -9, -7, -1, 0, 6, 8, 13, 15, 19, 25, 29,-24, -11, -9, -35, -31, 40, 41, 42, 49 },
            new int[] { -46, -35, -31, -29, -28, -27,-35, -31, -29, -28, -27, -15, -14, -10, -7, -1, 2, 7, 8, 15,-29, -28, -27,-35, -31, 20, 21, 25, 34, 47 },
            new int[] { -37, -30, -26, -22, -15, -5, -30, -26, -22, -15, -5, -4, -3, 15, 16, 18, 23, 28, 30, 36, -22, -15, -5, -30, -26, 38, 45, 48, 49, 50 }
            )] int[] array)
        {
            var sortingAlgorithm = new InsertionSort();
            var testArray = array.Clone() as int[];
            sortingAlgorithm.Sort(array);
            Assert.Pass();
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
        }

        [Test]
        [Sequential]
        public void SortOUnorderedIntShouldExecuteAndReturnSortedArray(
            [Values(
            new int[] { 10, -42, -32, 46, -15, -2, 29, 25, 43, -19, -10, -21, -47, -30, -24, 36, 48, 50, 28, 35 },
            new int[] { -13, -37, 21, -3, 11, 34, -48, 44, -14, -8, -32, 31, 10, 37, -30, 47, -41, -29, 39, 35 },
            new int[] { -35, -9, -38, -44, -17, -3, -22, 25, 2, 42, -27, 48, 50, 41, 6, -26, -48, -23, -11, 15 }
            )] int[] array)
        {
            var sortingAlgorithm = new InsertionSort();
            var testArray = array.Clone() as int[];
            sortingAlgorithm.Sort(array);
            Assert.Pass();
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
        }

        [Test]
        [Sequential]
        public void SortOUnorderedIntWithDuplicatesShouldExecuteAndReturnSortedArray(
            [Values(
            new int[] { 10, -42, -32, 10, -42, -32, 46, -15, -2, 29, 25, 43, -19, -10, -21, -47, -30, -24, 36, -30, -24, 36, 48, 50, 28, 35 },
            new int[] { -13, -37, 21,-13, -37, 21, -3, 11, 34, -48, 44, -14, -8, -32, 31, 10, 37, -30, 47, -41, -30, 47, -41, -29, 39, 35 },
            new int[] { -35, -9, -38, -35, -9, -38, -44, -17, -3, -22, 25, 2, 42, -27, 48, 50, 41, 6, -26, -48,  6, -26, -48, -23, -11, 15 }
            )] int[] array)
        {
            var sortingAlgorithm = new InsertionSort();
            var testArray = array.Clone() as int[];
            sortingAlgorithm.Sort(array);
            Assert.Pass();
            Assert.NotNull(array);
            Assert.IsTrue(array.Length == testArray.Length);
            Assert.IsTrue(Common.IsSorted(array));
        }
    }
}