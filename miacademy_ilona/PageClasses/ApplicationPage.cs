using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public class ApplicationPage : BasePage
    {
        public ApplicationPage(IWebDriver driver) : base(driver) { }

        public void FillFirstName(string firstName)
        {
            EnterText(ApplicationPageLocators.FirstNameInput, firstName);
        }

        public void FillLastName(string lastName)
        {
            EnterText(ApplicationPageLocators.LastNameInput, lastName);
        }

        public void FillEmail(string email)
        {
            EnterText(ApplicationPageLocators.EmailInput, email);
        }

        public void FillPhoneNumber(string phoneNumber)
        {
            EnterText(ApplicationPageLocators.PhoneInput, phoneNumber);
        }

        public void SelectYesInDropdown()
        {
            SelectDropdown(ApplicationPageLocators.DropdownParent, "Yes");
        }

        public void FillSecondParentInfo(string firstName, string lastName, string email, string phoneNumber)
        {
            EnterText(ApplicationPageLocators.FirstNameInputSecond, firstName);
            EnterText(ApplicationPageLocators.LastNameInputSecond, lastName);
            EnterText(ApplicationPageLocators.EmailInputSecond, email);
            EnterText(ApplicationPageLocators.PhoneInputSecond, phoneNumber);
        }

        public void ClickRandomCheckboxes(Random random)
        {
            var checkboxes = driver.FindElements(ApplicationPageLocators.Checkboxes);
            int checkboxCount = checkboxes.Count;
            int firstIndex = random.Next(checkboxCount);
            int secondIndex;
            do
            {
                secondIndex = random.Next(checkboxCount);
            } while (secondIndex == firstIndex);
            checkboxes[firstIndex].Click();
            checkboxes[secondIndex].Click();
        }

        public void SelectRandomCalendarDate(Random random)
        {
            Click(ApplicationPageLocators.CalendarElement);
            Click(ApplicationPageLocators.NextCalendarElement);
            var days = driver.FindElements(ApplicationPageLocators.Days);
            int randomIndex = random.Next(days.Count);
            days[randomIndex].Click();
        }

        public void ClickNextButton()
        {
            Click(ApplicationPageLocators.NextButtonElement);
        }
    }
}
