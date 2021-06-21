using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = "Naor";
            var client = new Client(new Proxy.Implementations.Proxy(new Implementations.Service()));
            client.Work(user);
            client.Auth(user);
            client.Work(user);
        }
    }
}
