using System.Collections.Generic;
namespace Eksamenslæsning
{
	class opg6Pair<T>
	{
		public readonly int first;
		public readonly int second;

		public opg6Pair(int first, int second)
		{
			this.first = first;
			this.second = second;
		}

		public opg6Pair<T> Swap()
		{
			return new opg6Pair<T>(second, first);
		}
	}
}