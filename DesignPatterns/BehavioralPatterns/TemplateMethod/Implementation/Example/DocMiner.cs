using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Implementation.Example
{
    class DocMiner : DataMiner
    {
        public DocMiner(bool required) : base (required)
        {

        }
        protected override void CloseFile(string file)
        {
            Console.WriteLine($"Close DOC file");
        }

        protected override string ExtractData(string file)
        {
            Console.WriteLine($"Extract DOC data");
            return "DOC DATA";
        }

        protected override string OpenFile(string path)
        {
            Console.WriteLine($"Opne DOC file with path = {path}");
            return "DOC";
        }

        protected override string ProcessData(string data)
        {
            Console.WriteLine($"Process DOC data");
            return "Processed DOC data";

        }
    }
}
