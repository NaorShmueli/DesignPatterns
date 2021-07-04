using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Implementation
{
    class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            element.FeatureA();
        }

        public void Visit(ElementB element)
        {
            element.FeatureA();
        }

        public void Visit(ElementC element)
        {
            element.AnotherFeature();
        }
    }
}
