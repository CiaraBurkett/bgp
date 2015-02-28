using System;

namespace Homework1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome User! \nThis application will calculate the maximum height and distance of the shell.");

			Console.WriteLine ("Please input the initial angle in degrees: ");
			float theta = float.Parse (Console.ReadLine ());

			Console.WriteLine ("Please input the initial speed: ");
			float speed = float.Parse (Console.ReadLine ());

			const float g = 9.8f;
			float vox = speed * (float)Math.Cos (theta * 0.0174532925);
			float voy = speed * (float)Math.Sin (theta * 0.0174532925);
			float t = voy / g;
			float h = voy * voy / (2 * g);
			float dx = vox * 2 * t;

			Console.WriteLine ("Results:");

			Console.WriteLine ("The height of the shell at apex will be: " + h + " meters.");

			Console.WriteLine ("The shell will travel " + dx + " meters.");

		}
	}
}
