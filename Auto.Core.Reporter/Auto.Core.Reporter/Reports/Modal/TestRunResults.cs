using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Reporter.Reports.Modal
{
    public class TestRunResults
    {
        public TestAttribute TestRun
        {
            get; set;
        }
        public List<TestScenarioResults> TestScenarios
        {
            get; set;
        }
    }
}
