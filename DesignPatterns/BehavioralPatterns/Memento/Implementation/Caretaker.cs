using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Implementation
{
    class Caretaker
    {
        private Stack<IMemento> _history;
        public Caretaker()
        {
            _history = new Stack<IMemento>();
        }

        public void Backup(IMemento memento)
        {
            _history.Push(memento);
        }
        public void Undo()
        {
            var history = _history.Pop();
            history.Restore();
            Console.WriteLine($"Originator: My state has changed to: {history.GetFullState()}");

        }
        public void PrintHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _history)
            {
                Console.WriteLine(memento.GetFullState());
            }
        }
    }
}
