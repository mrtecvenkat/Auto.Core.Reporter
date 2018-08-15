using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Reporter.Reports.Modal
{
    public class TestCaseResults
    {
        public TestAttribute TestCase
        {
            get; set;
        }
        public List<TestStepResults> TestSteps
        {
            get; set;
        }
    }
}
