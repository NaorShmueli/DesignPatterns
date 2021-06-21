using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ComplexSubSystem
{
    class ComplexService
    {
        public void Encode(VideoFile file, EncodingFormat encodingFormat)
        {
            Console.WriteLine($"Encoding file {file.FileName} with format {encodingFormat}");
        }


    }
}
