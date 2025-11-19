using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Algorithms.Sorting
{
	public static class SelectionSort
	{
		public static void Run(int[] intArr,int n)
		{
			for (int i = 0; i < n - 1; i++)
			{
				int minIndex = i;
				for (int j = i+1; j < n; j++)
				{
					if (intArr[minIndex] > intArr[j])
					{
						(intArr[minIndex], intArr[j]) = (intArr[j], intArr[minIndex]);
					}
				}
			}
			Console.WriteLine("Sorted Array: ");
			foreach (var item in intArr)
			{
				Console.Write(item + " ");
			}
		}
	}
}
