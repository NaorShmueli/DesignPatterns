using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    interface IReceiver
    {
        void WriteConsoleOperation(string msg);
        void HashMessageOperation(string msg);
        int ResultOperation(string msg);
    }
}
