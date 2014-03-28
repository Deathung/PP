using System;

namespace PP
{
	public class lab1
	{
		public class Student
		{
			public int korScore, mathScore;
			public double avg;
			public string name;
		}
		class MainClass
		{
			public static void Main(string[] args)
			{
				Student minsu = new Student ();
				minsu.korScore = 80;
				minsu.mathScore = 90;
				minsu.avg = (minsu.korScore + minsu.mathScore) / 2;
				minsu.name = "minsu";

				Student kain = new Student ();
				kain.korScore = 88;
				kain.mathScore = 60;
				kain.avg = (kain.korScore + kain.mathScore) / 2;
				kain.name = "kain";

				Console.WriteLine ("minsu's avg-> {0}, kain's avg-> {1}, their avg-> {2}",
					minsu.avg, kain.avg, (minsu.avg + kain.avg) / 2 );
			}
		}
	}
}

