using Iterator.Example.Tree.Implementation;
using Iterator.Structure.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string [] args)
        {
            var collection = new ConcreteCollection(new string[] { "str1", "str2", "str3" });
            var iterator = collection.CreateIterator();
            while (iterator.HasMore())
            {
                var next = iterator.GetNext();
                Console.WriteLine(next);
            }
        }
	}
}
