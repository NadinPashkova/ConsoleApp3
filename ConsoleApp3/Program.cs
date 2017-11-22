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
		    var list = new List(5);

		    list.AddToTheEnd(6);

		    list.AddToTheEnd(7);

		    Console.WriteLine("print all element : 5, 6, 7");

		    list.Print();


            list.Delete(0);

		    System.Console.WriteLine("print all element: delete 5 ");

		    list.Print();

		    list.AddToTheBegining(8);

		    Console.WriteLine("print all element : 8, 6, 7");

		    list.Print();

		    Console.ReadKey();
		}
	}
}
