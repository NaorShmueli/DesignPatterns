using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementations
{
    class Service : IServiceInterface
    {
        public void Operation(string user)
        {
            Console.WriteLine($"Service working for user {user}");
        }
    }
}
