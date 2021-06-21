using Facade.ComplexSubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Implementations
{
    /// <summary>
    /// This Facade will work with complex service objects and do the job
    /// he will know all relevant object for required job and init them
    /// the client communicate with this Facade only.!
    /// </summary>
    class Facade
    {
        private readonly ComplexService _complexService;
        //Optional for complext Facade
        private readonly OptionalAdditionalFacade _optionalAdditionalFacade;

        public Facade()
        {
            _complexService = new ComplexService();
            _optionalAdditionalFacade = new OptionalAdditionalFacade();
        }
        public void Encode(string fileName)
        {
            var format = EncodingFormat.DCT;
            var videoFile = new VideoFile(fileName);
            _complexService.Encode(videoFile, format);
        }
    }
}
