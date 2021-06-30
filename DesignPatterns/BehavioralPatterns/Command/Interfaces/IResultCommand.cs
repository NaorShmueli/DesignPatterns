using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    interface IResultCommand<T> where T : struct
    {
        T Execute(string msg);
    }
}
