using System;

static class Fibonacci
{
	public static void PrintFibonacci(int upto)
	{
		int n = upto; // Number of terms
		int first = 0, second = 1;

		Console.WriteLine("Fibonacci Series:");

		for (int i = 0; i < n; i++)
		{
			Console.Write(first + " ");

			int next = first + second;
			first = second;
			second = next;
		}
	}
}
