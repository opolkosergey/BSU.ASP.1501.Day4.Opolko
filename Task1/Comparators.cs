using System;
using System.Linq;

namespace Task1
{
    public class DecreaseSumRowComparator : IArrayComparator
    {
        public int RowResult(int[] row)
        {
            return (row == null) ? int.MinValue : -1 * row.Sum();
        }
    }

    public class IncreaseSumRowComparator : IArrayComparator
    {
        public int RowResult(int[] row)
        {
            return (row == null) ? int.MinValue : row.Sum();
        }
    }

    public class DecreaseMaxAbsElementRowComparator : IArrayComparator
    {
        public int RowResult(int[] row)
        {
            if (row == null)
                return int.MaxValue;
            if (row.Length == 0)
                return int.MaxValue;
            return -1 * row.Max(a => Math.Abs(a));
        }
    }

    public class IncreaseMaxAbsElementRowComparator : IArrayComparator
    {
        public int RowResult(int[] row)
        {
            if (row == null)
                return int.MinValue;
            if (row.Length == 0)
                return int.MinValue;
            return row.Max(a => Math.Abs(a));
        }
    }
}
