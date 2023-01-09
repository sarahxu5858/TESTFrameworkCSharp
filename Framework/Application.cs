using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.BaseTest;
using Framework.PageObject;

namespace Framework
{
    public class Application
    {
        public Application(IWebDriver driver) {

            //initiate page objects here
            //  = new Homepage(driver);
           var basepage = new BasePage(driver);
           var datadriven = new TryDat
        }


    }
}