using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "김기태";
			int k = 40;

			Console.WriteLine($"Hellow {name}");
			Console.WriteLine("Hellow " + name);
			//Console.WriteLine("Hellow " + name +" "+ name);
			Console.WriteLine("Hellow {0} {1}", name, k);
		}
	}
}
