using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
		    var list = new ListNode() {Value = 5};

		    list.Add(6);

		    list.Add(7);

		    list.Delete(0);

		    System.Console.WriteLine("print all element");

		    list.Print();
		}
	}
}
