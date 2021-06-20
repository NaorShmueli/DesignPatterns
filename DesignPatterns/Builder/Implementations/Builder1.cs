using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implementations
{
    class Builder1 : IBuilder
    {
        private ProductResult1 _result;
        public Builder1()
        {
            _result = new ProductResult1();
        }
        public void BuildStepA()
        {
            Console.WriteLine("Build StepA");
            _result.FeatureA = "Add feature A";
        }

        public void BuildStepB()
        {
            _result.FeatureB = "Add feature B";
            Console.WriteLine("Build StepB");
        }

        public void BuildStepX()
        {
            _result.FeatureX = "Add feature X";
            Console.WriteLine("Build StepX");
        }

        public void Reset()
        {
            _result = new ProductResult1();
        }

        public ProductResult1 GetResult()
        {
            return _result;
        }
    }
}
