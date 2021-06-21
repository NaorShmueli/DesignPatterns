using Composite.Implementations;
using Composite.Interfaces;
using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new Leaf(5);
            var item2 = new Leaf(6);
            var item3 = new Leaf(7);
            var item4 = new Leaf(8);
            var box1 = new Composite.Implementations.Composite(new List<IComponent> { item1, item2, item3, item4 });
            var box2 = new Composite.Implementations.Composite(new List<IComponent> { item1, item2, item3, item4 });

            var item5 = new Leaf(55);
            var item6 = new Leaf(65);
            var item7 = new Leaf(75);
            var item8 = new Leaf(88);
            var item9 = new Leaf(100);
            var item10 = new Leaf(100);

            var box3 = new Composite.Implementations.Composite(new List<IComponent> { item5, item6, item7, item8, box1, item9, box2 });
            var box4 = new Composite.Implementations.Composite(new List<IComponent> { box3, item10 });
            var client = new Client(box4);
            var price = client.GetPrice();
            Console.WriteLine($"Object Tree Price = {price}");

        }
    }
}
