﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TypeCastExample1
{
	class Program
	{
		public static void Main() //(string[] args)
		{
			short a = 10;
			int b = a;
			int c = 50000;
			//short d = (short)c;
			//Console.WriteLine("Short:{0}", d);
			//------------------------------------
			try
			{
				short d = checked((short)c);
				Console.WriteLine("Short:{0}", d);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("\n");
				Console.WriteLine(e.StackTrace);
			}
		}
	}
}
