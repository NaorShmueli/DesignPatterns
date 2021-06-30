using Iterator.Example.Tree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example.Tree.Implementation
{
    public abstract class TreeEnumerator<T> : IEnumerator<INode<T>>
    {
        // Contains the original parent tree.
        protected INode<T> _Tree = null;

        // Contains the current node.
        protected INode<T> _Current = null;

        // Constructor.
        // The parameter tree is the main tree.
        public TreeEnumerator(INode<T> tree)
        {
            _Tree = tree;
        }

        // Get the explicit current node.
        public INode<T> Current { get { return _Current; } }

        // Get the implicit current node.
        object System.Collections.IEnumerator.Current
        {
            get { return _Current; }
        }

        // Increment the iterator and moves the current node to the next one
        public abstract bool MoveNext();

        // Dispose the object.
        public void Dispose()
        {
        }

        // Reset the iterator.
        public void Reset()
        {
            _Current = null;
        }

        // Get the underlying enumerator.
        public virtual TreeEnumerator<T> GetEnumerator()
        {
            return this;
        }
    }
}
