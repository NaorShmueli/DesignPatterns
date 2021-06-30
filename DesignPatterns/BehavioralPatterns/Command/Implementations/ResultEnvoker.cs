using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    class ResultEnvoker
    {
        private IResultCommand<int> _command;

        public void SetCommand(IResultCommand<int> command)
        {
            _command = command;
        }

        public int ExecuteCommand(string msg)
        {
            return _command.Execute(msg);
        }
    }
}
