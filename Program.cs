using Algorithms;
using Collections;
using Conversions;
using CSharpPrograms.Algorithms.Sorting;
using CSharpPrograms.DesignPatterns.Creational;
using LeetCodeChallenges;
using OOPS;
using Programs;
internal class Program
{
    private static void Main(string[] args)
    {
		#region Collections
		//ArrayExample.Run();
		//ListExample.Run();
		//HashSetExample.Run();
		#endregion

		#region OOPS
		//Polymorphism.Run();
		// A obj=new B();
		// obj.Write();

		#endregion

		#region Conversions
		// Boxing.Run();
		// UnBoxing.Run();
		#endregion

		#region Programs
		//Prime
		//PrimeNumber.Run(7);
		//Calculator.Run();
		//UniqueChars.Run();
		#endregion

		#region Searching Algorithms
		// int[] sortedIntArray = [1, 2, 3, 5, 11, 18, 57, 58, 59, 67];
		// BinarySearch.Run(sortedIntArray, 100);
		#endregion
		#region Sorting Algorithms
		int[] intArray = { 5, 2, 8, 12, 1 };
		int arrSize = intArray.Length;
		Console.WriteLine("Original Array: ");
		foreach (var item in intArray)
		{
			Console.Write(item + " ");
		}


		BubbleSort.Run(intArray, arrSize);
		#endregion

		#region LeetCode
		//Problem20.Run();
		//Problem27.Run();
		#endregion

		#region DesignPatterns
		// SingletonDemo.Run();
		#endregion

	}
}