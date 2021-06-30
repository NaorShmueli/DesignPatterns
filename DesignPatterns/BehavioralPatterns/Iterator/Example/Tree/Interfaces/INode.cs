using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example.Tree.Interfaces
{
	public interface INode<T>
	{
		INode<T> Parent { get; set; }
		INode<T> Child { get; set; }
		INode<T> Right { get; set; }
	}
}
