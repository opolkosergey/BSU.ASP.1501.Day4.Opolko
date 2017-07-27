using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Task1.Tests
{
	[TestClass]
	public class BubbleSortTests
	{
		IArrayComparator increaseSumInRow = new IncreaseSumRowComparator();
		IArrayComparator decreaseSumInRow = new DecreaseSumRowComparator();
		IArrayComparator increaseMaxAbsInRow = new IncreaseMaxAbsElementRowComparator();
		IArrayComparator decreaseMaxAbsInRow = new DecreaseMaxAbsElementRowComparator();

		[TestMethod]
		public void SortBubblesort_increaseSum_Test()
		{
			int[][] jaggedArray =
			{
				new [] {-61,3,0},
				new [] {5,2,45},
				null,
				new [] {10,46}
			};

			int[][] increaseSumInRowResult =
			{
				null,
				new [] {-61,3,0},
				new [] {5,2,45},
				new [] {10,46}
			};

			Sort.BubbleSort(jaggedArray, increaseSumInRow);
			IStructuralEquatable arrays = jaggedArray;
			Assert.AreEqual(arrays.Equals(increaseSumInRowResult, StructuralComparisons.StructuralEqualityComparer), true);
		}

		[TestMethod]
		public void SortBubblesort_decreaseSum_Test()
		{
			int[][] jaggedArray =
			{
				new [] {-61,3,0},
				new [] {5,2,45},
				null,
				new [] {10,46}
			};

			int[][] decreaseSumInRowResult =
			{
				null,
				new [] {10,46},
				new [] {5,2,45},
				new [] {-61,3,0}
			};

			Sort.BubbleSort(jaggedArray, decreaseSumInRow);
			IStructuralEquatable arrays = jaggedArray;
			Assert.AreEqual(arrays.Equals(decreaseSumInRowResult, StructuralComparisons.StructuralEqualityComparer), true);
		}

		[TestMethod]
		public void SortBubblesort_increaseMaxAbs_Test()
		{
			int[][] jaggedArray =
			{
				new [] {-61,3,0},
				new [] {5,2,45},
				null,
				new [] {10,46}
			};

			int[][] increaseMaxAbsInRowResult =
			{
				null,
				new [] {5,2,45},
				new [] {10,46},
				new [] {-61,3,0}
			};

			Sort.BubbleSort(jaggedArray, increaseMaxAbsInRow);
			IStructuralEquatable arrays = jaggedArray;
			Assert.AreEqual(arrays.Equals(increaseMaxAbsInRowResult, StructuralComparisons.StructuralEqualityComparer), true);
		}

		[TestMethod]
		public void SortBubblesort_decreaseMaxAbs_Test()
		{
			int[][] jaggedArray =
			{
				new [] {-61,3,0},
				new [] {5,2,45},
				null,
				new [] {10,46}
			};

			int[][] decreaseMaxAbsInRowResult =
			{
				new [] {-61,3,0},
				new [] {10,46},
				new [] {5,2,45},
				null
			};

			Sort.BubbleSort(jaggedArray, decreaseMaxAbsInRow);
			IStructuralEquatable arrays = jaggedArray;
			Assert.AreEqual(arrays.Equals(decreaseMaxAbsInRowResult, StructuralComparisons.StructuralEqualityComparer), true);
		}
	}
}
