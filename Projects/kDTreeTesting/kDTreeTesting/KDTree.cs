using System;
namespace kDTreeTesting
{
	public class KDTree
	{
		public void kdt()
		{
			int[,] kDTree = new int[,] {
				{1,9},
				{2,3},
				{4,1},
				{3,7},
				{5,4},
				{6,8},
				{7,2},
				{8,8},
				{7,9},
				{9,6}};

			// 20
			int fullLength = kDTree.Length;

			// 10
			int halfLength = fullLength / 2;

			// 5
			int x = fullLength / 4;

			// 0
			int y = 0;

			// Finding median for x
			int medianX = kDTree[x, y];

			// Split the data into two
			int[,] firstSplit = new int[x, x];
			int[,] secondSplit = new int[x, x];

			for (int i = 0; i < halfLength; i++)
			{
				for (int j = 0; j < halfLength; j++)
				{
					firstSplit[i, j] = kDTree[i, j];
					secondSplit[i, j] = kDTree[i + halfLength, j + halfLength];
					Console.WriteLine($"F{firstSplit[i, j]} S{secondSplit[i, j]}");
				}
			}
		}
	}
}
