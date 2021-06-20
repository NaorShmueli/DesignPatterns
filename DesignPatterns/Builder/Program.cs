using Builder.Implementations;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Builder1());
            var product = client.GetProduct();
            Console.WriteLine(product.ToString());
            product = client.GetProductX();
            Console.WriteLine(product.ToString());
        }
    }
}
