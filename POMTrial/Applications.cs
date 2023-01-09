using AventStack.ExtentReports;
using OpenQA.Selenium;
using POMTrial.PageObjects.YouTube;
using POMTrial.PageObjects;

namespace POMTrial
{
    public class Applications
    {
        public SearchPage searchPage;
        public ResultPage resultPage;
        public DataDriven datadriven;
        public Applications(IWebDriver driver, ExtentTest test)
        {
            searchPage = new SearchPage(driver, test);
            resultPage = new ResultPage(driver, test);
            datadriven = new DataDriven(driver, test);
        }
    }
}
