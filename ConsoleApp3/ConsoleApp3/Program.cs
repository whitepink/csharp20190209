using System;


namespace ConsoleApp3
{
	class LogicalAnd
	{
		//static void Main(string[] args)
		//{
		//	Console.WriteLine("정상적인 AND");
		//	if(Method1() & Method2())
		//		Console.WriteLine("Both method returned true");
		//	else
		//		Console.WriteLine("둘중하나의 메소드는 false");

		//	Console.WriteLine("\n Short-circuit AND");
		//	if(Method1() && Method2())
		//		Console.WriteLine("\n Short method returned true.");
		//	else
		//		Console.WriteLine("둘중 하나는 false");
		//}

		//static bool Method1()
		//{
		//	Console.WriteLine("메소드1...");
		//	return false;
		//}

		//static bool Method2()
		//{
		//	Console.WriteLine("메소드2...");
		//	return true;
		//}


		//static void Main(string[] args)
		//{
		//	object a = null;
		//	object b = "abc";

		//	object c = a ?? b;
		//	Console.WriteLine(c);

		//	object d;

		//	if (a != null)
		//	{
		//		d = a;
		//	}
		//	else
		//	{
		//		d = b;
		//	}
		//	Console.WriteLine(d);
		//	//-------------------
		//	//object e;
		//	//e = (a != null)
		//}
		//=================================
		// 3. reference 
		//=================================
		class Rtype
		{
			public object Value;
		}

		class Program
		{
			static void Main(string[] args)
			{
				Rtype a = new Rtype();
				Rtype b = new Rtype();

				a.Value = 1;
				b = a;
				Console.WriteLine(a.Value);
				Console.WriteLine(b.Value);

				b.Value = 2;
				Console.WriteLine(a.Value);
				Console.WriteLine(b.Value);
			}
		}
	}
}
