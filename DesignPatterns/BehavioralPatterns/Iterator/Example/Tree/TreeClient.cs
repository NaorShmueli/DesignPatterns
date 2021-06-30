using Iterator.Example.Tree.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example.Tree
{
	//TODO
    class TreeClient
	{
		public void Run(string[] args)
		{
			// Build the node.
			Node tree = new Node(1);
			tree.Child = new Node(2);
			tree.Child.Right = new Node(5);
			tree.Child.Child = new Node(3);
			tree.Child.Child.Right = new Node(4);
			tree.Child.Right.Child = new Node(6);
			tree.Child.Right.Child.Right = new Node(7);

			int imax = 2;
			double[] ratios = new double[imax];
			ulong iter = 1;
			for (int i = 0; i < imax; i++)
				ratios[i] = TestPerformance(tree, iter);

			StringBuilder sb = new StringBuilder();
			foreach (double value in ratios)
				sb.Append(value.ToString() + ";");
			string copy = sb.ToString();
			Console.WriteLine(copy);
		}
		private double TestPerformance(Node tree, ulong iter)
		{
			DateTime start;

			// Classic method test
			start = DateTime.Now;
			long ticks1 = 0;
			for (ulong i = 0; i < iter; i++)
			{
				DepthTreeEnumerator<int> enumerator;
				enumerator = new DepthTreeEnumerator<int>(tree);
				foreach (Node node in enumerator) { Console.WriteLine(node.Value); }

				ticks1 = ((TimeSpan)(DateTime.Now - start)).Ticks;
				Console.WriteLine($"Classic time {ticks1}");
			}
			// Yield return method test
			start = DateTime.Now;
			for (ulong i = 0; i < iter; i++)
			{
				foreach (Node node in MoveNext(tree)) { Console.WriteLine(node.Value); }
			}
			long ticks2 = ((TimeSpan)(DateTime.Now - start)).Ticks;
			Console.WriteLine($"Yield return time {ticks2}");

			return (double)ticks2 / (double)ticks1;
		}

		// Define a yield return method iteration.
		private IEnumerable<Node> MoveNext(Node root)
		{
			yield return root;
			if (root.Child != null)
				foreach (Node node in MoveNext((Node)root.Child))
					yield return node;
			if (root.Right != null)
				foreach (Node node in MoveNext((Node)root.Right))
					yield return node;
		}
	}
}
