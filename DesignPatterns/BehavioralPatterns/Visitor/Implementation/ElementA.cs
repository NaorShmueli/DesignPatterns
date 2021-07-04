using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Implementation
{

    /// <summary>
    /// This is BIG class and we can extension it with new method Accept only and new field IVisitor
    /// new functionality that the in charge of IVisitor
    /// </summary>
    internal class ElementA : IElement
    {        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void FeatureA()
        {
            Console.WriteLine("New functionality");
            Console.WriteLine("Feature A of ElementA working");
        }
    }
}
