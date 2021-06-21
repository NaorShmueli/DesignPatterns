using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Implementations
{
    class Flyweight
    {
        //This field is common between all system particle
        // like color of something or image
        public string _reapitingState;

        public Flyweight(string reapitingState)
        {
            _reapitingState = reapitingState;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uniqueState"> this field is unique and changing along the application
        /// like bullet vector etc..
        /// </param>
        public void Operation(string uniqueState)
        {
            Console.WriteLine($"Flyweight working with uniqueState = {uniqueState}");
        }
    }
}
