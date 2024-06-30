using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BrowserTests.PageObjects;
using System;
using System.Collections.Generic;

namespace BrowserTests
{
    [TestFixture]
    public class InitialAppicationTests
    {
        private IWebDriver driver = null!;
        private HomePage homePage = null!;
        private NavigationPage basePage = null!;
        private ApplicationPage applicationPage = null!;
        private OnlineSchoolPage onlineSchoolPage = null!;
        private StudentApplicationPage studentApplicationPage = null!;
        private Random random = null!;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            homePage = new HomePage(driver);
            basePage = new NavigationPage(driver);
            onlineSchoolPage = new OnlineSchoolPage(driver);
            applicationPage = new ApplicationPage(driver);
            studentApplicationPage = new StudentApplicationPage(driver);
            random = new Random();
        }

        [Test]
        public void OpenBrowserAndNavigateToUrl()
        {
            basePage.OpenUrl(HomePageLinks.Url);
            homePage.ClickOnlineHighLink();
            onlineSchoolPage.ClickApplyLink();

            var firstNames = new List<string> { "John", "Jane", "Alex", "Emily", "Michael", "Sarah", "David", "Laura" };
            string randomFirstName = firstNames[random.Next(firstNames.Count)];
            applicationPage.FillFirstName(randomFirstName);

            var lastNames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };
            string randomLastName = lastNames[random.Next(lastNames.Count)];
            applicationPage.FillLastName(randomLastName);

            string randomEmail = $"{randomFirstName.ToLower()}{randomLastName.ToLower()}@gmail.com";
            applicationPage.FillEmail(randomEmail);

            string randomPhoneNumber = GenerateRandomPhoneNumber(random);
            applicationPage.FillPhoneNumber(randomPhoneNumber);

            applicationPage.SelectYesInDropdown();

            string randomFirstNameSecond = firstNames[random.Next(firstNames.Count)];
            string randomLastNameSecond = lastNames[random.Next(lastNames.Count)];
            string randomEmailSecond = $"{randomFirstNameSecond.ToLower()}{randomLastNameSecond.ToLower()}@gmail.com";
            string randomPhoneNumberSecond = GenerateRandomPhoneNumber(random);

            applicationPage.FillSecondParentInfo(randomFirstNameSecond, randomLastNameSecond, randomEmailSecond, randomPhoneNumberSecond);
            applicationPage.ClickRandomCheckboxes(random);
            applicationPage.SelectRandomCalendarDate(random);
            applicationPage.ClickNextButton();
            string studentInfoText = studentApplicationPage.GetStudentPageLabelText();
            Assert.That(studentInfoText, Is.EqualTo("Student Information"), "The text of the Student Information section does not match.");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        private string GenerateRandomPhoneNumber(Random random)
        {
            int areaCode = random.Next(100, 1000);
            int exchangeCode = random.Next(100, 1000);
            int subscriberNumber = random.Next(1000, 10000);
            return $"({areaCode}) {exchangeCode}-{subscriberNumber}";
        }
    }
}
