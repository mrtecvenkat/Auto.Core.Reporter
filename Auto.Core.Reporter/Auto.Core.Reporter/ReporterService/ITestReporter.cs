using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Core.Reporter.Reports.Modal;

namespace Auto.Core.Reporter.ReporterService
{
    public interface ITestReporter
    {
        TestRunResults CreateReport(string testName, string reportPath);
        TestScenarioResults StartScenarioReport(string scenarioName);
        TestCaseResults StartTestCaseReport(string testCaseName);
        void EndTestCaseReporting(TestCaseResults testCaseResults);
        void EndScenarioReporting(TestScenarioResults scenarioResults);
        void CloseReport(TestRunResults testRunResluts);
    }
}
