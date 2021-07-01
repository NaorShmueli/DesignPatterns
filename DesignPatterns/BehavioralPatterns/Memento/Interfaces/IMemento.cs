using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Interfaces
{
    interface IMemento
    {
        string GetText();
        string GetFullState();
        int GetSize();
        bool GetBold();
        DateTime GetDate();
    }
}
