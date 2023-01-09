using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Framework.BaseTest
{
    public class BaseTest
    {
        public IWebDriver driver;
        public Application application; 
        public BaseTest()
        {

        }
        
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            application = new Application(driver);
            
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}