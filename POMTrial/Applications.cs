using AventStack.ExtentReports;
using OpenQA.Selenium;
using POMTrial.BaseClass.BaseT;
using POMTrial.PageObjects.YouTube;
using POMTrial.PageObjects.YouTube.SerachObj;
using POMTrial;
using POMTrial.TestSteps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
