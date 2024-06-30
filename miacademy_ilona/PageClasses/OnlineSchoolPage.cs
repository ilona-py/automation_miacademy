using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public class OnlineSchoolPage : BasePage
    {
        public OnlineSchoolPage(IWebDriver driver) : base(driver) { }

        public void ClickApplyLink()
        {
            Click(OnlineSchoolPageLocators.LinkApply);
        }
    }
}
