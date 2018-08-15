using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Reporter.Reports.Modal
{
    public class TestStepResults
    {
        public string Action
        {
            get; set;
        }
        public string Target
        {
            get; set;
        }
        public string Value
        {
            get; set;
        }
        public bool IsSuccess
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public string FileName
        {
            get; set;
        }
        public string FilePath
        {
            get; set;
        }

    }
}
