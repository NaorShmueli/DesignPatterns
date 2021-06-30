using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    class ResultCommand : IResultCommand<int>
    {
        private readonly IReceiver _receiver;
        public ResultCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        public int Execute(string msg)
        {
            return _receiver.ResultOperation(msg);
        }
    }
}
