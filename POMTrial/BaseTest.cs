using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMTrial.PageObjects.YouTube.SerachObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTrial.BaseClass.BaseT
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
         
            //driver.Url = "https://www.youtube.com/";           
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
