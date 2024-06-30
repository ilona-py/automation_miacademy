using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BrowserTests.PageObjects;
using System;

namespace BrowserTests
{
    public class ConfigurationTest
    {
        protected IWebDriver driver = null!;
        protected HomePage homePage = null!;
        protected NavigationPage basePage = null!;
        protected ApplicationPage applicationPage = null!;
        protected OnlineSchoolPage onlineSchoolPage = null!;
        protected StudentApplicationPage studentApplicationPage = null!;
        protected Random random = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            basePage = new NavigationPage(driver);
            onlineSchoolPage = new OnlineSchoolPage(driver);
            applicationPage = new ApplicationPage(driver);
            studentApplicationPage = new StudentApplicationPage(driver);
            random = new Random();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}