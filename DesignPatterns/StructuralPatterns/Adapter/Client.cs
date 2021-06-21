using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Implementaion;
namespace Adapter
{
    class Client
    {
        private readonly IServiceClient _serviceClient;
        public Client()
        {
            _serviceClient = new Adapter.Implementaion.Adapter();
        }

        public void ClientWork(string json)
        {
            _serviceClient.SomeOperationForClient(json);
        }
    }
}
