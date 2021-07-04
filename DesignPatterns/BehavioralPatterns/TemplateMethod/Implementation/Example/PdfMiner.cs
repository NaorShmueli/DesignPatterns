using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Implementation.Example
{
    class PdfMiner : DataMiner
    {
        public PdfMiner(bool required) :base(required)
        {

        }
        protected override void CloseFile(string file)
        {
            Console.WriteLine($"Close PDF file");
        }

        protected override string ExtractData(string file)
        {
            Console.WriteLine($"Extract PDF data");
            return "PDF DATA";
        }

        protected override string OpenFile(string path)
        {
            Console.WriteLine($"Opne PDF file with path = {path}");
            return "PDF";
        }

        protected override string ProcessData(string data)
        {
            Console.WriteLine($"Process PDF data");
            return "Processed PDF data";
           
        }
    }
}
