using System;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList characterRecords = new SortedList();

			characterRecords.Add("a");
			characterRecords.Add("c");
			characterRecords.Add("e");
			characterRecords.Add("b");
			characterRecords.Add("f");
            characterRecords.Add("d");

			characterRecords.SetSortStrategy(new QuickSort());
			characterRecords.Sort();

			characterRecords.SetSortStrategy(new ShellSort());
			characterRecords.Sort();

			characterRecords.SetSortStrategy(new MergeSort());
			characterRecords.Sort();

			Console.ReadKey();
		}
	}
}
