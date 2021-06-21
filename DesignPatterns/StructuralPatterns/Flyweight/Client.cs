using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Client
    {
        public void StartGame(string user)
        {
            Console.WriteLine($"User {user} starting play");
            var context = new Implementations.Context("Red", "bullet on center page");
            context.SomeOperation();
            var contex2 = new Implementations.Context("Red", "bullet on the end page");
            contex2.SomeOperation();
            var contex3 = new Implementations.Context("Red", "bullet dissappear");
            contex3.SomeOperation();

            Console.WriteLine("Please see flyweight factry create only 1 very consuming resources object and 3 context object with unique data");
        }
    }
}
