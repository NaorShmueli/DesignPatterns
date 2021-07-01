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
        private Editor _editor;
        public Caretaker(Editor editor)
        {
            _editor = editor;
            _history = new Stack<IMemento>();
        }

        public void Backup()
        {
            this._history.Push(_editor.Save());
        }
        public void Undo()
        {
            var history = _history.Pop();
           _editor.Restore(history);
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
