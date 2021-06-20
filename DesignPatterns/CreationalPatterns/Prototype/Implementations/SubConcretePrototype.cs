using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    class SubConcretePrototype : ConcretePrototype, ICloneable
    {
        public string Field2 { get; set; }
        public SubConcretePrototype() :base()
        {

        }
        public SubConcretePrototype(SubConcretePrototype prototype): base(prototype)
        {
            Field2 = prototype.Field2;
        }

        public override object Clone()
        {
            return new SubConcretePrototype(this);
        }
    }
}
