using POMTrial.BaseClass;
using POMTrial.PageObjects.YouTube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POMTrial.PageObjects.YouTube.SerachObj;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMTrial.BaseClass.BaseT;
using AventStack.ExtentReports;

namespace POMTrial.TestSteps
{
    [TestFixture]
    public class YoutubeDemo1: BaseTest
    {
       
        [Test, Category("Smoke")]
       // [TestCaseSource(typeof(DataModule),"")]
        public void TestMethod1()
        {
            string url = "https://youtube.com";
            var inputText = "tiktok 2023";

                applications.searchPage.OpenYouTobe(url);
                applications.searchPage.NavigateToResult(inputText);

                applications.resultPage.NavigateToChannel();
               // Thread.Sleep(10000);
                
                    
       
        }
    }
}
