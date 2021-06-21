using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    class AdvancedDecorator : BaseDecorator
    {
        public AdvancedDecorator(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"Will do extra work, this is extanding of decorator");
            Console.WriteLine($"Work befor base.Execute();");
            base.Execute();
            Console.WriteLine($"Work After base.Execute();");

        }
    }
}
