using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace POMTrial.PageObjects.YouTube
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
