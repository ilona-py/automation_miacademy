using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BrowserTests.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement Find(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void Click(By locator)
        {
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            element.Click();
        }

        public void EnterText(By locator, string text)
        {
            var element = Find(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public void SelectDropdown(By locator, string text)
        {
            Click(locator);
            var dropdownOption = By.XPath($"//li[contains(text(), '{text}')]");
            Click(dropdownOption);
        }
    }
}
