using System;

class Program
{
	static void Main()
	{
		int n = 10; // Number of terms
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
