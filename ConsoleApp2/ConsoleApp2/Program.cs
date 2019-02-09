using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		//==================================================
		// 1. 
		//==================================================
		static void Main(string[] args)
		{
			Console.WriteLine("3+3");
			Console.WriteLine(+3);
			Console.WriteLine(3 + 3);
			Console.WriteLine(3 + .3);
			Console.WriteLine("3" + "3");
			Console.WriteLine(3.0 + "3");

			Console.WriteLine(!true);

			byte x = 10;
			Console.WriteLine(~x);
			Console.WriteLine(unchecked((short)50000));
		}

		//==================================================
		// 2. 
		//==================================================
		//static void Main(string[] args)
		//{
		//	Emp e = new Emp();
		//	Programmer p = new Programmer();
		//	Emp e1 = p as Emp;
		//	//Emp e2 = (Emp)p;
		//}

		class Emp
		{
			string name;
			void GotoOffice() { }
		}

		class Programmer : Emp { }
	}

}
