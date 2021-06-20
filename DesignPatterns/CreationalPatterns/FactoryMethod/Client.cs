using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Client
    {
        private readonly ICreator _creator;
        public Client(ICreator creator)
        {
            _creator = creator;
        }

        public void Deliver()
        {
            var deliver = _creator.CreateDeliver();
            deliver.DeliverBox();
        }
    }
}
