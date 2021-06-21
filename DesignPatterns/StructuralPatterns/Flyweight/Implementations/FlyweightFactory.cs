using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Implementations
{
    class FlyweightFactory
    {
        private static IDictionary<string,Flyweight> _cache;
        static FlyweightFactory()
        {
            _cache = new Dictionary<string, Flyweight>();
        }

        public static Flyweight GetFlyweight(string reapitingState)
        {
            if (_cache.ContainsKey(reapitingState))
            {
                return _cache[reapitingState];
            }
            var newFlyweight = new Flyweight(reapitingState);
            _cache.Add(reapitingState, newFlyweight);
            return newFlyweight;
        }
    }
}
