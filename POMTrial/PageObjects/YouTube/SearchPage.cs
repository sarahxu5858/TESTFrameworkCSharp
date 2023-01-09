using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Events;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Internal;
using AventStack.ExtentReports;

namespace POMTrial.PageObjects.YouTube.SerachObj
{
    public class SearchPage : BasePage
    {
       public SearchPage(IWebDriver driver, ExtentTest test) : base(driver, test)
        {

        }

        By SearchTextbox = By.XPath("//input[@id='search']");       
        By searchBtn = By.Id("search-icon-legacy");

        
        public void OpenYouTobe(string url)
        {
            OpenUrl(url);
        }
        public void NavigateToResult(string text)
         {
            Input_text(SearchTextbox, text);
            Click(searchBtn);

         }

     
    }
}
