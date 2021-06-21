using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.AdapteeService
{
    class Service
    {
        public void ServicOperation(string dataXml)
        {
            Console.WriteLine($"Write only data xml. Data = {dataXml}");
        }
    }
}
