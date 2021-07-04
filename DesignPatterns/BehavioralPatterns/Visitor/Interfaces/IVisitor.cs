using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Implementation;

namespace Visitor.Interfaces
{
    interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
        void Visit(ElementC element);

    }
}
