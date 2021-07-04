using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Implementation
{
    class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void FeatureA()
        {
            Console.WriteLine("New functionality");
            Console.WriteLine("Feature A of ElementB working");
        }
    }
}
