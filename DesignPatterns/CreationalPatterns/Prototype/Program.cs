using Prototype.Implementations;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new ConcretePrototype { Id = 1, Name = "Naor" };
            var clone = obj1.Clone();
            var obj2 = new SubConcretePrototype { Field2 = "Data", Name = "Naor", Id = 2 };
            var obj2Clone = obj2.Clone();
        }
    }
}
