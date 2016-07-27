using System;
using Models;

namespace Prototype
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var obj = new Models.Prototype(0,1,2);
			var clone = obj.Clone();

			Console.WriteLine("Original object : ID - {0}, Height - {1}, Width - {2}", obj.Id, obj.Height, obj.Width);
			Console.WriteLine("Clone object : ID - {0}, Height - {1}, Width - {2}", clone.Id, clone.Height, clone.Width);
			Console.WriteLine();

			clone.Height = 40;
			clone.Width = 60;

			Console.WriteLine("Clone and original object after modification of clone object: ");
			Console.WriteLine("Original object : ID - {0}, Height - {1}, Width - {2}", obj.Id, obj.Height, obj.Width);
			Console.WriteLine("Clone object : ID - {0}, Height - {1}, Width - {2}", clone.Id, clone.Height, clone.Width);
			Console.ReadKey();
		}
	}
}
