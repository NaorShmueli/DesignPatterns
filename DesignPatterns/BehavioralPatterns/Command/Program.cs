using Command.Implementations;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandReceiver = new Receiver();
            var consoleCommand = new WriterConsoleMessageCommand(commandReceiver);
            var invoker = new Envoker();
            invoker.SetCommand(consoleCommand);
            invoker.ExecuteCommand("My message");

            var hashCommand = new HashStringCommand(commandReceiver);
            invoker.SetCommand(hashCommand);
            invoker.ExecuteCommand("My message");

            var resultCommand = new ResultCommand(commandReceiver);
            var resultInvoker = new ResultEnvoker();
            resultInvoker.SetCommand(resultCommand);
            resultInvoker.ExecuteCommand("My message");
        }
    }
}
