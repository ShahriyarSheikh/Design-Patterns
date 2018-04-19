using System;
using System.Collections.Generic;

namespace Strategy
{
	class ShellSort : SortStrategy
	{
		public override void Sort(List<string> list)
		{
			//list.ShellSort(); not-implemented but will implement shortly
			Console.WriteLine("ShellSorted list ");
		}
	}
}
