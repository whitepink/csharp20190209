using System;
using System.Runtime.InteropServices;

namespace TypeCastExample2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(default(int));

			int iSize = sizeof(int);
			Console.WriteLine("int형 바이트 길이 : {0}", iSize);

			Type myType1 = typeof(int);
			Console.WriteLine("typeof(int) : {0}", myType1);

			int i = 10;
			Type myTest2 = i.GetType();
			Console.WriteLine("i.GetTye() : {0}", myTest2);

			int j = 99;
			Console.WriteLine("Size of j : {0}", Marshal.SizeOf(j));
		}
	}
}
