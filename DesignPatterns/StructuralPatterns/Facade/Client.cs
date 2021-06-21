using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Client
    {
        private readonly Facade.Implementations.Facade _facade;

        public Client(Facade.Implementations.Facade facade)
        {
            _facade = facade;
        }

        public void Encode(string fileName)
        {
            _facade.Encode(fileName);
        }
    }
}
