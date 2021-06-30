using Iterator.Example.Tree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example.Tree.Implementation
{
	public class DepthTreeEnumerator<T> : TreeEnumerator<T>
	{
		public DepthTreeEnumerator(INode<T> tree)
		: base(tree) { }

		public override bool MoveNext()
		{
			if (_Current == null) _Current = _Tree;
			else if (_Current.Child != null) _Current = _Current.Child;
			else if (_Current.Right != null) _Current = _Current.Right;
			else
			{
				// The current node has no more child node
				INode <T> node = _Current;
				do
				{
					if (node.Parent == null) return false;
					node = node.Parent;
				} while (node.Right == null);
				_Current = node.Right;
			}

			return true;
		}
	}
}
