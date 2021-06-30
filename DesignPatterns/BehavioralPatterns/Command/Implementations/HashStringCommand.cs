using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    class HashStringCommand : ICommand
    {
        private readonly IReceiver _receiver;
        public HashStringCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute(string msg)
        {
            _receiver.HashMessageOperation(msg);
        }
    
    }
}
