using System;

namespace Task1
{
    public static class Sort
    {
        public static void BubbleSort(int[][] array, IArrayComparator comparator)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (comparator == null)
                throw new ArgumentNullException(nameof(comparator));

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (comparator.RowResult(array[i]) > comparator.RowResult(array[j]))
                    {
                        ReplaceRows(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void ReplaceRows(ref int[] a, ref int[] b)
        {
            int[] row = a;
            a = b;
            b = row;
        }
    }
}
