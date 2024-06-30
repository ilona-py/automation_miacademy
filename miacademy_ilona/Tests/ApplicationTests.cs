using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Xml.Linq;


namespace BrowserTests
{
    [TestFixture]
    public class BrowserInitializationTests
    {
        private IWebDriver driver = null!; 
        private Random random = new Random();

        [SetUp]
        public void Setup()
        {
            // Initialize ChromeDriver
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void OpenBrowserAndNavigateToUrl()
        {
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            var LinkOnlineHigh = driver.FindElement(By.XPath("//div[@class='mia-MiaPrepAnnouncement mia-VueControl']//a[@href]"));
            LinkOnlineHigh.Click();
            var LinkApply = driver.FindElement(By.XPath("(//a[contains(text(), 'Apply to Our School')])[1]"));
            LinkApply.Click();
            var inputElement = driver.FindElement(By.XPath("//*[@id='Name-li']//input[@elname='First']"));
            var firstNames = new List<string> { "John", "Jane", "Alex", "Emily", "Michael", "Sarah", "David", "Laura" };
            string randomFirstName = firstNames[random.Next(firstNames.Count)];
            inputElement.SendKeys(randomFirstName);
            var lastNames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };
            string randomLastName = lastNames[random.Next(lastNames.Count)];
            var lastNameInputElement = driver.FindElement(By.XPath("//*[@id='Name-li']//input[@elname='Last']"));
            lastNameInputElement.SendKeys(randomLastName);
            string randomEmail = $"{randomFirstName.ToLower()}{randomLastName.ToLower()}@gmail.com";
            var emailInputElement = driver.FindElement(By.Id("Email-arialabel"));
            emailInputElement.SendKeys(randomEmail);
            string randomPhoneNumber = GenerateRandomPhoneNumber(random);
            var phoneInputElement = driver.FindElement(By.XPath("//input[@name='PhoneNumber']"));
            phoneInputElement.SendKeys(randomPhoneNumber);
            var dropdownParentElement = driver.FindElement(By.Id("select2-Dropdown-arialabel-container"));
            dropdownParentElement.Click();
            var dropdownAppeared = driver.FindElement(By.XPath("//*[@id='select2-Dropdown-arialabel-container']//ancestor::span[@aria-labelledby='select2-Dropdown-arialabel-container']"));
            Assert.That(dropdownAppeared, Is.Not.Null, "Element was not found on page");
            string ariaExpanded = dropdownAppeared.GetAttribute("aria-expanded");
            Assert.That(ariaExpanded, Is.EqualTo("true"), "Атрибут aria-expanded не дорівнює 'true'.");
            var yesDropdownElement = driver.FindElement(By.XPath("//span[@class='select2-results']//li[contains(text(), 'Yes')]"));
            yesDropdownElement.Click();
            var secondParentInformation = driver.FindElement(By.XPath("//h2//b[contains(text(), 'Second Parent Information')]"));
            Assert.That(secondParentInformation, Is.Not.Null, "Element was not found on page");
            var inputElementSecond = driver.FindElement(By.XPath("//*[@id='Name1-li']//input[@elname='First']"));
            var firstNamesSecond = new List<string> { "John", "Jane", "Alex", "Emily", "Michael", "Sarah", "David", "Laura" };
            string randomFirstNameSecond = firstNamesSecond[random.Next(firstNamesSecond.Count)];
            inputElementSecond.SendKeys(randomFirstNameSecond);
            var lastNamesSecond = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };
            string randomLastNameSecond = lastNamesSecond[random.Next(lastNamesSecond.Count)];
            var lastNameInputElementSecond = driver.FindElement(By.XPath("//*[@id='Name1-li']//input[@elname='Last']"));
            lastNameInputElementSecond.SendKeys(randomLastNameSecond);
            string randomEmailSecond = $"{randomFirstName.ToLower()}{randomLastName.ToLower()}@gmail.com";
            var emailInputElementSecond = driver.FindElement(By.Id("Email1-arialabel"));
            emailInputElementSecond.SendKeys(randomEmailSecond);
            string randomPhoneNumberSecond = GenerateRandomPhoneNumber(random);
            var phoneInputElementSecond = driver.FindElement(By.Id("PhoneNumber1"));
            phoneInputElementSecond.SendKeys(randomPhoneNumberSecond);
            var checkboxes = driver.FindElements(By.XPath("//li[@id='Checkbox-li']//em[@class='cusChoiceEm']"));
            int checkboxCount = checkboxes.Count;
            int firstIndex = random.Next(checkboxCount);
            int secondIndex;
            do
            {
                secondIndex = random.Next(checkboxCount);
            } while (secondIndex == firstIndex);
            checkboxes[firstIndex].Click();
            checkboxes[secondIndex].Click();
            var calendarElement = driver.FindElement(By.XPath("//div[@class='calendarCont']//input[@name='Date']"));
            calendarElement.Click();
            var nextCalendarElement = driver.FindElement(By.XPath("//a[@class='ui-datepicker-next ui-corner-all'][@data-handler='next']"));
            nextCalendarElement.Click();
            var days = driver.FindElements(By.XPath("//div[@id='ui-datepicker-div']//tbody//td[@data-handler='selectDay']"));
            int dayCount = days.Count;
            int randomIndex = random.Next(dayCount);
            days[randomIndex].Click();
            var nextButtonElement = driver.FindElement(By.XPath("//ul[@page_no='1']//button[@elname='next']"));
            nextButtonElement.Click();
        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        static string GenerateRandomPhoneNumber(Random random)
        {
            int areaCode = random.Next(100, 1000);
            int exchangeCode = random.Next(100, 1000);
            int subscriberNumber = random.Next(1000, 10000);

            return $"({areaCode}) {exchangeCode}-{subscriberNumber}";
        }
    }
}
