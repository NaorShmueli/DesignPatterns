using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    class ConcretePrototype : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ConcretePrototype()
        {

        }
        public ConcretePrototype(ConcretePrototype prototype)
        {
            Id = prototype.Id;
            Name = prototype.Name;
        }
        public virtual object Clone()
        {
            return new ConcretePrototype(this);
        }
    }
}
