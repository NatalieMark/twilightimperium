using System;
namespace Eksamenslæsning
{
	public class opg6
	{
		public opg6(int a, int b, int c, bool t, bool f)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.t = t;
			this.f = f;
		}

		int a;
		int b;
		int c;
		bool t;
		bool f;

		public void StupidExcercise()
		{
			Console.WriteLine(a == b);
			Console.WriteLine(a == c);
			Console.WriteLine(b == c);
			Console.WriteLine(t == f);
		}
	}
}
