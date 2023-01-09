using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace POMTrial.BaseClass
{
    public class BaseTest
    {
        private IWebDriver driver;
        public Applications applications;
        protected ExtentReports extent;
        protected ExtentTest test;

        [SetUp]
        public void Open()
        {
            extent = new ExtentReports();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            var reporter = new ExtentHtmlReporter(".\\POMTrial\\POMTrial\\Reports\\");
            extent.AttachReporter(reporter);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);    
                  
            test.Log(Status.Info, "opened homepage");
            applications = new Applications(driver, test);
        }

        [TearDown]
        public void Close() 
        {
            extent.Flush();
            driver.Quit();
        }
    }
}
