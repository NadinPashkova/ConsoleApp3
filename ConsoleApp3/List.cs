using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class List
	{
		private ListNode _headNode;

		private ListNode _lastNode;

	    public int Counter { get; set ; }


		public List(int value)
		{
		    Counter = 1;

            _headNode = new ListNode() { Value = value};

			_lastNode = _headNode;

		}

		public void AddToTheEnd(int value)
		{

            var node = new ListNode { Value = value };

            _lastNode.NextNode = node;

		    _lastNode = node;

		    Counter++;
		}

	    public void AddToTheBegining(int value)
	    {

	        var node = new ListNode { Value = value };

	        node.NextNode = _headNode;

	        _headNode = node;
	    }

        public void Delete(int index)
		{
			var node = this[index];
		
			if (index < 0 || index > Counter - 1)
			{
				Console.WriteLine("Index is out of range");
				return;
			}

			if (node.NextNode == null)
			{
				if (index == 0)
				{
					_headNode = null;
					return;
				}

				this[index - 1].NextNode = null;
				return;
			}

		    if (index == 0)
		    {
		        _headNode = _headNode.NextNode;
		        return;
		    }

		    this[index - 1].NextNode = this[index + 1];
		}

		public ListNode this[int index]
		{
 			get
			{
			    var count = 0;

				if (index < 0 || index > Counter - 1)
				{
					Console.WriteLine($"there is no node with index {index}");
					return null;
				}

				var node = _headNode;

				while (count != index)
				{
					node = node.NextNode;
                    count++;
				}

				return node;
			}
		}

		public void Print()
		{
			var node = _headNode;

			while (node.NextNode != null)
			{
				Console.WriteLine(node.Value);

				node = node.NextNode;

				if (node.NextNode == null)
					Console.WriteLine(node.Value);
			}
		}
	}
}
