using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 -- To shuffle an array a of n elements (indices 0..n-1):
for i from n−1 downto 1 do
     j ← random integer such that 0 ≤ j ≤ i
     exchange a[j] and a[i]

 -- To shuffle an array a of n elements (indices 0..n-1):
for i from 0 to n−2 do
     j ← random integer such that i ≤ j < n
     exchange a[i] and a[j]

 */


namespace Sortix.Shuffling
{
    /// <summary>
    /// Shuffling class.
    /// </summary>
    public class Shuffler
    {
        private static Random random;

        public Shuffler(Random randomGenerator)
        {
            random = randomGenerator;
        }

        /// <summary>
        /// Shuffle an array of doubles. Reference type. O(n)
        /// </summary>
        /// <param name="array">Array to shuffle</param>
        public void Shuffle<T>(T[] array) where T : IComparable
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
