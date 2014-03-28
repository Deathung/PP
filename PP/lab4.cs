using System;

namespace PP
{
	public class lab4
	{
		public class Circle
		{
			public double x, y, r;
		}
		class MainClass
		{
			public static void Main(string[] args)
			{
				Circle c1 = new Circle ();
				Circle c2 = new Circle ();

				Console.WriteLine (" x : ");
				c1.x = Convert.ToDouble(Console.ReadLine ());
				Console.WriteLine (" y : ");
				c1.y = Convert.ToDouble(Console.ReadLine ());
				Console.WriteLine (" r : ");
				c1.r = Convert.ToDouble(Console.ReadLine ());

				Console.WriteLine (" x : ");
				c2.x = Convert.ToDouble(Console.ReadLine ());
				Console.WriteLine (" y : ");
				c2.y = Convert.ToDouble(Console.ReadLine ());
				Console.WriteLine (" r : ");
				c2.r = Convert.ToDouble(Console.ReadLine ());

				double dis = Math.Sqrt (Math.Pow ((c1.x - c2.x), 2) + Math.Pow ((c1.y - c2.y), 2));
				if (dis <= c1.r + c2.r)
					Console.WriteLine ("collsion!");
				else
					Console.WriteLine ("not happen");
			}
		}
	}
}

