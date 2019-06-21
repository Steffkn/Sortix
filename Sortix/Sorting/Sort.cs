using System;

namespace Sortix.Sorting
{
    public abstract class SortingAlgorithm
    {
        public abstract void Sort<T>(T[] array) where T : IComparable;
    }
}