using OpenQA.Selenium;
using AventStack.ExtentReports;


namespace POMTrial.PageObjects
{
    public class DataDriven : BasePage
    {
        public DataDriven(IWebDriver driver, ExtentTest test) : base(driver, test)
        {

        }

        public new void OpenUrl(string url)
        {
            base.OpenUrl(url);
        }

    }
}
