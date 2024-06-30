using NUnit.Framework;
using BrowserTests.PageObjects;
using BrowserTests.Utilities;

namespace BrowserTests
{
    [TestFixture]
    public class InitialApplicationTests : ConfigurationTest
    {
        [Test]
        public void TestInitialApplicationForm()
        {
            basePage.OpenUrl(HomePageLinks.Url);
            homePage.ClickOnlineHighLink();
            onlineSchoolPage.ClickApplyLink();

            string randomFirstName = RandomDataGenerator.GenerateRandomFirstName(random);
            applicationPage.FillFirstName(randomFirstName);

            string randomLastName = RandomDataGenerator.GenerateRandomLastName(random);
            applicationPage.FillLastName(randomLastName);

            string randomEmail = $"{randomFirstName.ToLower()}{randomLastName.ToLower()}@gmail.com";
            applicationPage.FillEmail(randomEmail);

            string randomPhoneNumber = RandomDataGenerator.GenerateRandomPhoneNumber(random);
            applicationPage.FillPhoneNumber(randomPhoneNumber);

            applicationPage.SelectYesInDropdown();

            string randomFirstNameSecond = RandomDataGenerator.GenerateRandomFirstName(random);
            string randomLastNameSecond = RandomDataGenerator.GenerateRandomLastName(random);
            string randomEmailSecond = $"{randomFirstNameSecond.ToLower()}{randomLastNameSecond.ToLower()}@gmail.com";
            string randomPhoneNumberSecond = RandomDataGenerator.GenerateRandomPhoneNumber(random);

            applicationPage.FillSecondParentInfo(randomFirstNameSecond, randomLastNameSecond, randomEmailSecond, randomPhoneNumberSecond);
            applicationPage.ClickRandomCheckboxes(random);
            applicationPage.SelectRandomCalendarDate(random);
            applicationPage.ClickNextButton();

            string studentInfoText = studentApplicationPage.GetStudentPageLabelText();
            Assert.That(studentInfoText, Is.EqualTo("Student Information"), "The text of the Student Information section does not match.");
        }
    }
}
