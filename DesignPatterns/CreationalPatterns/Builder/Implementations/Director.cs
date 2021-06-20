using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implementations
{
    class Director
    {
        private readonly IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void MakeProduct()
        {
            _builder.BuildStepA();
            _builder.BuildStepB();
        }

        public void MakeOnlyX()
        {
            _builder.Reset();
            _builder.BuildStepX();
        }
    }
}
