using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Implementation
{
    class Editor : IOriginator
    {
        public string Text { get; set; }
        public int Size { get; set; }
        public bool IsBold { get; set; }

        public IMemento Save()
        {
            return new Snapshot(this, Text, Size, IsBold);
        }
    }
}
