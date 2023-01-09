using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObject
{
    public class BasePage

    {
        IWebDriver driver;
        
        public BasePage(IWebDriver driver) { 
        
        }

        public void FindElement(By locator)
        {
            driver.FindElement(locator);
        } 
        


    }
}
