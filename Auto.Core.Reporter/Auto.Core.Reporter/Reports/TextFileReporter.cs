using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Core.Reporter.ReporterService;
using Auto.Core.Reporter.Reports.Modal;

namespace Auto.Core.Reporter.Reports
{
    public class TextFileReporter : ITestReporter
    {
        public TestRunResults CreateReport(string testName, string reportPath)
        {
            throw new NotImplementedException();
        }
        public TestScenarioResults StartScenarioReport(string scenarioName)
        {
            throw new NotImplementedException();
        }

        public TestCaseResults StartTestCaseReport(string testCaseName)
        {
            throw new NotImplementedException();
        }
        public void EndScenarioReporting(TestScenarioResults scenarioResults)
        {
            throw new NotImplementedException();
        }

        public void EndTestCaseReporting(TestCaseResults testCaseResults)
        {
            throw new NotImplementedException();
        }
        public void CloseReport(TestRunResults testRunResluts)
        {
            throw new NotImplementedException();
        }
    }
}
