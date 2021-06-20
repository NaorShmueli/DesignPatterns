using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implementations
{
    /// <summary>
    /// Result type like wooden house 
    /// Not all feature must implemented maybe the house not contains pool
    /// </summary>
    class ProductResult1
    {
        public string FeatureA { get; set; }
        public string FeatureB { get; set; }
        public string FeatureX { get; set; }
        public string Pool { get; set; }

        public override string ToString()
        {
            return $"Feature 1: {FeatureA??"None"}, Feature 2: {FeatureB??"None"}, Feature 3: {FeatureX??"None"}, Pool: {Pool??"None"}";
        }
    }
}
