using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    interface ICommand
    {
        void Execute(string msg);
    }
}
