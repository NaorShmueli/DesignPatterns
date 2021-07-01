using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Interfaces
{
    interface IMemento
    {
        string GetFullState();
        void Restore();

    }
}
