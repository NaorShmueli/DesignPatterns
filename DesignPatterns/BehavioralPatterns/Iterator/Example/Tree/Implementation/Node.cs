using Iterator.Example.Tree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example.Tree.Implementation
{
    class Node : INode<int>
    {
        public Node(int val, INode<int> parent)
        {
            Value = val;
            Parent = parent;
        }

        public Node(int val)
        {
            Value = val;
        }

        public int Value { get; set; }
        public INode<int> Parent { get; set; }
        public INode<int> Child { get; set; }
        public INode<int> Right { get; set; }
    }
}
