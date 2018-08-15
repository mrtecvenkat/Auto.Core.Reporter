using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Core.Reporter.ReporterService;
using Auto.Core.Reporter.Reports.Modal;
using Newtonsoft.Json;

namespace Auto.Core.Reporter.Reports
{
    public class JSONReporter : ITestReporter
    {
        private TestRunResults curRunResutls = null;
        private TestScenarioResults curScenarioResults = null;
        private TestCaseResults curTestCaseResults = null;
        private TestStepResults curStepResults = null;
        private string curReportPath = null;

        public TestRunResults CreateReport(string testName, string reportPath)
        {
            curRunResutls = new TestRunResults();
            curRunResutls.TestRun = new TestAttribute();
            curRunResutls.TestRun.Name = testName;

            return curRunResutls;
        }
        public void CloseReport(TestRunResults testRunResluts)
        {
            throw new NotImplementedException();
        }


        public TestScenarioResults StartScenarioReport(string scenarioName)
        {
            throw new NotImplementedException();
        }
        public void EndScenarioReporting(TestScenarioResults scenarioResults)
        {
            throw new NotImplementedException();
        }

        public TestCaseResults StartTestCaseReport(string testCaseName)
        {
            throw new NotImplementedException();
        }
        public void EndTestCaseReporting(TestCaseResults testCaseResults)
        {
            throw new NotImplementedException();
        }




    }
}
