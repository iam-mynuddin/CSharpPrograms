using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Algorithms.Sorting
{
	public static class InsertionSort
	{
		public static void Run(int[] intArr, int n)
		{
		 for (int i=1;i<n;i++)
			{
				int key = intArr[i];
				int j = i - 1;
				while(j>=0 && intArr[j] > key)
				{
					intArr[j + 1] = intArr[j];
					j--;
				}
				intArr[j + 1] = key;
			}

			Console.WriteLine("Sorted Array: ");
			foreach (var item in intArr)
			{
				Console.Write(item + " ");
			}
		}
	}
}
