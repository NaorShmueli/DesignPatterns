using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Client
    {
        private readonly IServiceInterface _serviceInterface;

        public Client(IServiceInterface service)
        {
            _serviceInterface = service;
        }

        public void Work(string user)
        {
            _serviceInterface.Operation(user);
        }

        public void Auth(string user)
        {
            (_serviceInterface as Proxy.Implementations.Proxy).Auth();
            Console.WriteLine($"User {user} is now Auth");

        }
    }
}
