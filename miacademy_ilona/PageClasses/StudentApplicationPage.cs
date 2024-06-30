using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public class StudentApplicationPage : BasePage
    {
        public StudentApplicationPage(IWebDriver driver) : base(driver) { }

        public string GetStudentPageLabelText()
        {
            var element = Find(StudentPageLocators.StudentPageLabelElement);
            return element.Text;
        }
    }
}

