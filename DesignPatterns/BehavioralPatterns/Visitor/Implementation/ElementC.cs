using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Implementation
{
    class ElementC : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void AnotherFeature()
        {
            Console.WriteLine("New functionality");
            Console.WriteLine("AnotherFeature of ElementC working");
        }
    }
}
