using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTrial.PageObjects.YouTube
{
    public class ResultPage : BasePage
    {
        public ResultPage(IWebDriver driver, ExtentTest test) : base(driver, test)
        {

        }
        By ChannelNameLinkText = By.PartialLinkText("2023");

        public void NavigateToChannel()
        {
          Click(ChannelNameLinkText);
        }
    }
}
