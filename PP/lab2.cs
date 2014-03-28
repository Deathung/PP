using System;

namespace PP
{
	public class lab2
	{
		public static void Main (string[] args)
		{
			string name;
			int width, height;

			Console.WriteLine ("what's your name? : ");
			name = Console.ReadLine ();
			Console.WriteLine ("how long width? : ");
			width = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine ("how long height? : ");
			height = Convert.ToInt32(Console.ReadLine ());

			Console.WriteLine ("{0}'s extent is {1}", name, width * height);
		}
	}
}

