using System;

namespace Lab2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int age = 28;
			Console.WriteLine("Ciara is " + age + " years old");

			const int MAX_SCORE = 100;
			int score = 50;
			float percent = (float)score / MAX_SCORE;

			Console.WriteLine ("Ciara's current score is " + percent + " of the maximum score.");
		}
	}
}
