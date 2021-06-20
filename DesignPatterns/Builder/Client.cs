using Builder.Implementations;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Client
    {
        private readonly Director _director;
        private readonly Builder1 _builder;

        public Client(IBuilder builder)
        {
            _builder = builder as Builder1;
            _director = new Director(builder);
        }

        internal ProductResult1 GetProduct()
        {
            _director.MakeProduct();
            return _builder.GetResult();
                
        }
        internal ProductResult1 GetProductX()
        {
            _director.MakeOnlyX();
            return _builder.GetResult();

        }
    }
}
