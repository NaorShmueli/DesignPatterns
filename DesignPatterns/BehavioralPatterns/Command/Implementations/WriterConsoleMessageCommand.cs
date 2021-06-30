using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    class WriterConsoleMessageCommand : ICommand
    {
        private readonly IReceiver _receiver;

        public WriterConsoleMessageCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute(string msg)
        {
            _receiver.WriteConsoleOperation(msg);
        }
    }
}
