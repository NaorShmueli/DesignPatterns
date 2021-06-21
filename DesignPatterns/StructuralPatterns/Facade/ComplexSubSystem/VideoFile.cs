using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ComplexSubSystem
{
    class VideoFile
    {
        public string FileName { get; set; }
        public VideoFile(string fileName)
        {
            FileName = fileName;
        }
    }
}
