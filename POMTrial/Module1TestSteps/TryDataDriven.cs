using POMTrial.BaseClass;
using POMTrial.ReadParserData;
using NUnit.Framework;

namespace POMTrial
{
    public class TryDataDriven : BaseTest
    {
        [Test, Category("Module1"), Category("Regression"), TestCaseSource(typeof(ExcelDataParser), nameof(ExcelDataParser.BudgetData))]
        public void Test1(string urladdress)
        {
            applications.datadriven.OpenUrl(urladdress);
        }
    }
}
