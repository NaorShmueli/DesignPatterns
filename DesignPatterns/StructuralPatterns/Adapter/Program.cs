using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.ClientWork("Json Data");
        }
    }
}
