using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Database;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using POMTrial.BaseClass.BaseT;

namespace POMTrial
{
    [TestFixture]
    public class Tests : BaseTest
    {
        //[Parallelizable]
        //[SetUp]
        //public void Setup()
        //{
        //    Console.WriteLine("opening browser");
        //}

        [Test, Category("Smoke Testing"), Author("BoXu")]
        public void Test1()
        {
            var reporter = new ExtentHtmlReporter("D:\\POMTrial\\POMTrial\\ExtendReport\\");
            var extent = new ExtentReports();
            extent.AttachReporter(reporter);
            //ExtentReports
            var test = extent.CreateTest("Test1");

            var chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(chromeOptions);
            try
            {
                test.Info("opening url");
               
                //driver.Navigate().GoToUrl("https://www.selenium.dev/");
                test.Info("Finding abc element");
                IWebElement emailField = driver.FindElement(By.Id("email"));
                emailField.SendKeys("Selenium C#");

                test.Pass("Test1 Pass");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                test.Fail(e.StackTrace);
                throw;

            }
            finally
            {
                driver.Quit();
            }

            extent.Flush();
        }
        [Test, Category("Smoke Testing")]
        public void Test2()
            
        {
            
            var reporter = new ExtentHtmlReporter("D:\\POMTrial\\");

            // create ExtentReports and attach reporter(s)
            var extent = new ExtentReports();
            extent.AttachReporter(reporter);
            //ExtentReports
            var test = extent.CreateTest("Test1");

            IWebDriver driver = new FirefoxDriver();
            try
            {
                test.Info("opening url");
                driver.Url = "";
                driver.Navigate().GoToUrl("https://www.selenium.dev/");
                test.Info("Finding abc element");
                IWebElement a = driver.FindElement(By.Id("abc"));

                test.Pass("Test1 Pass");

            }
            catch (Exception e)
            {
               
                Console.WriteLine(e.StackTrace);
            }
        }
        //[TearDown]

        //public void Teardown()
        //{
        //    Console.WriteLine("closing broswer");

        //}
        [Test, Category("Regression Testing")]
        public void Test3()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new InternetExplorerDriver();
            IWebElement a = driver.FindElement(By.Id("abc"));
        }
    }

}