using System;
using TemplateMethod.Implementation.Example;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********PDF***********");
            var pdfMiner = new PdfMiner(true);
            pdfMiner.MineData("PATH/TO/FILE");
            Console.WriteLine("**********DOC*********");
            var docMiner = new DocMiner(true);
            docMiner.MineData("PATH/TO/FILE");
        }
    }
}
