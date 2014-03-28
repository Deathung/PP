using System;

namespace PP
{
	public class lab3
	{
		public static void Main (string[] args)
		{
			const int SIZE = 15;
			int[] arr;
			int sum = 0;
			arr = new int[SIZE];

			for(int i = 0; i < SIZE; i++)
			{
				Console.Write("num[{0}]?", i);
				arr[i] = Convert.ToInt32(Console.ReadLine());
				sum += arr [i];
			}
			Console.WriteLine ("Sum : " + sum);
		}
	}
}

