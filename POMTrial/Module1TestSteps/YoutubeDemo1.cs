using POMTrial.BaseClass;
using NUnit.Framework;

namespace POMTrial.TestSteps
{
    [TestFixture]
    public class YoutubeDemo1 : BaseTest
    {

        [Test, Category("Smoke")]
        public void TestMethod1()
        {
            string url = "https://youtube.com";
            var inputText = "tiktok 2023";

            applications.searchPage.OpenYouTobe(url);
            applications.searchPage.NavigateToResult(inputText);

            applications.resultPage.NavigateToChannel();
        }
    }
}
