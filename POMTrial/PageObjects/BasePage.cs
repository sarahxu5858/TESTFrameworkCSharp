using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using SeleniumExtras.WaitHelpers;

namespace POMTrial.PageObjects
{
    public class BasePage
    {
        IWebDriver driver;
        ExtentTest testlog;
        protected BasePage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            testlog = test;

        }

        protected void OpenUrl(string url)
        {
            testlog.Log(Status.Info, "Open url");
            driver.Url = url;
        }

        protected IWebElement FindElement(By locator)
        {
            testlog.Log(Status.Info, $"FindElement{locator}");
            return driver.FindElement(locator);
        }

        protected IList<IWebElement> FindElements(By locator)
        {
            testlog.Log(Status.Info, $"FindElements{locator}");
            return driver.FindElements(locator);
        }

        protected virtual void Click(By locator)
        {
            testlog.Log(Status.Info, $"Click Element{locator}");
            driver.FindElement(locator).Click();
        }

        protected virtual void Input_text(By locator, string text)
        {
            testlog.Log(Status.Info, $"Inputing {text}");
            IWebElement a;
            a = driver.FindElement(locator);
            a.Clear();
            a.SendKeys(text);
        }

        protected virtual void Verify_element_text(string expected_text, By locator)
        {
            testlog.Log(Status.Info, $"verifying {expected_text} text");
            string actualText;
            actualText = driver.FindElement(locator).Text;
            Assert.IsTrue(actualText.Equals(expected_text));

        }

        protected void Verify_partial_text(string expected_text, By locator)
        {
            testlog.Log(Status.Info, $"verifying {expected_text}");
            string actualText;
            actualText = driver.FindElement(locator).Text;

            Assert.IsTrue(actualText.Contains(expected_text));

        }

        protected void Verify_url_contains_query(string query)
        {
            testlog.Log(Status.Info, $"verifying {query} in URL");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(dr => dr.Url.Contains(query));
        }

        protected void Veirfy_wait_until_visiable(By locator)
        {
            testlog.Log(Status.Info, $"verify element {locator} visable");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
