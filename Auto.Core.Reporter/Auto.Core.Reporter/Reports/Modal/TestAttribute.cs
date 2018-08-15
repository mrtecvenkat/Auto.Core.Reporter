using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Reporter.Reports.Modal
{
    public class TestAttribute
    {
        public string Name
        {
            get; set;
        }
        public string StartDateAndTime
        {
            get; set;
        }
        public string EndDateAndTime
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
    }
}
