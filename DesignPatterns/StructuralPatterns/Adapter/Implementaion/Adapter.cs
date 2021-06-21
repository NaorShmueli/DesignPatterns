using Adapter.AdapteeService;
using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementaion
{
    class Adapter : IServiceClient
    {
        private readonly Service _adaptee;
        public Adapter()
        {
            _adaptee = new Service();
        }
        public void SomeOperationForClient(string jsonData)
        {
            Console.WriteLine("Convert json data to xml");
            Console.WriteLine("Call adaptee method with xml data");
            Console.WriteLine("Return what ever you want");
            var xml = jsonData.Replace("Json", "XML");
            _adaptee.ServicOperation(xml);
        }
    }
}
