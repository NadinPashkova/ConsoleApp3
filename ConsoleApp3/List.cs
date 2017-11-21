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



		public List(int value)
		{

			_headNode = new ListNode() { Value = value, Index = 0 };

			_lastNode = _headNode;

		}

		public void Add(int value)
		{
			_lastNode.NextNode = new ListNode { Value = value, Index = _lastNode.Index + 1 };

		}


		public void Delete(int index)
		{
			var node = this[index];

		
			if (index < 0 || index > _lastNode.Index)
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
				_headNode = _headNode.NextNode











		}




		public ListNode this[int index]
		{
			get
			{
				if (index < 0 || index > _lastNode.Index)
				{
					Console.WriteLine($"there is no node with index {index}");
					return null;
				}

				var node = _headNode;

				while (node.Index != index)
				{
					node = node.NextNode;
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
