
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Interfaces
{
    interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(string request);

    }
}
