using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Reporter.Reports.Modal
{
    public class TestScenarioResults
    {
        public TestAttribute TestScenario
        {
            get; set;
        }
        public List<TestCaseResults> TestCases
        {
            get; set;
        }
    }
}
