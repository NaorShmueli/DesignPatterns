using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Implementation.Example
{
    public abstract class DataMiner
    {
        private readonly bool _requiredData;
        public DataMiner(bool requiredData)
        {
            _requiredData = requiredData;
        }
        public void MineData(string path)
        {
            if (_requiredData)
            {
                var file = OpenFile(path);
                var data = ExtractData(file);
                var processed = ProcessData(data);
                var analysis = AnalysisData(processed);
                SendReport(analysis);
                CloseFile(file);
            }
        }

        protected virtual string AnalysisData(string data)
        {
            Console.WriteLine($"Analysis data");
            return "Analysis";
        }
        protected virtual void SendReport(string analaysis)
        {
            Console.WriteLine($"Send report");
        }

        protected abstract string OpenFile(string path);
        protected abstract string ExtractData(string file);
        protected abstract string ProcessData(string data);
        protected abstract void CloseFile(string file);

    }
}
