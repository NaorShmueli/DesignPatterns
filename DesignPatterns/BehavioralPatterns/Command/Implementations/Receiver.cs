using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementations
{
    class Receiver : IReceiver
    {
        public void WriteConsoleOperation(string msg)
        {
            Console.WriteLine("************WriteConsoleOperation*************");
            Console.WriteLine(msg);
        }

        public void HashMessageOperation(string msg)
        {
            Console.WriteLine("************HashMessageOperation*************");

            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, msg);
                Console.WriteLine($"Message : {msg}, Hash = {hash}");
            }
        }

        public int ResultOperation(string msg)
        {
            Console.WriteLine("************ResultOperation*************");
            return msg.GetHashCode();
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
