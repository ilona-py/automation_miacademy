using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public void ClickOnlineHighLink()
        {
            Click(HomePageLocators.LinkOnlineHigh);
        }
    }
}

