using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementation
{
    class ConcreteSubscriber : ISubscriber
    {
        public void Update(object context)
        {
            Console.WriteLine($"ConcreteSubscriber Get update from publisher with context {context}");
        }
    }
}
