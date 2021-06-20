using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    interface ICreator
    {
        IProduct CreateDeliver();
    }
}
