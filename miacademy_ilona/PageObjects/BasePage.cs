using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public class NavigationPage
    {
        protected IWebDriver driver;

        public NavigationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenUrl(string url, int timeout = 30)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);
        }
    }
}

