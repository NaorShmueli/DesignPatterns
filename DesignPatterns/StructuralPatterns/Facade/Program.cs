using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Facade.Implementations.Facade());
            client.Encode("someVideo.mp4");
        }
    }
}
