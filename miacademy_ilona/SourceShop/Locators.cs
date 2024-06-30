using OpenQA.Selenium;

namespace BrowserTests.PageObjects
{
    public static class HomePageLocators
    {
        public static readonly By LinkOnlineHigh = By.XPath("//div[@class='mia-MiaPrepAnnouncement mia-VueControl']//a[@href]");
    }

    public static class OnlineSchoolPageLocators
    {
        public static readonly By LinkApply = By.XPath("(//a[contains(text(), 'Apply to Our School')])[1]");
    }

        public static class ApplicationPageLocators
    {
        public static readonly By FirstNameInput = By.XPath("//*[@id='Name-li']//input[@elname='First']");
        public static readonly By LastNameInput = By.XPath("//*[@id='Name-li']//input[@elname='Last']");
        public static readonly By EmailInput = By.Id("Email-arialabel");
        public static readonly By PhoneInput = By.XPath("//input[@name='PhoneNumber']");
        public static readonly By DropdownParent = By.Id("select2-Dropdown-arialabel-container");
        public static readonly By DropdownAppeared = By.XPath("//*[@id='select2-Dropdown-arialabel-container']//ancestor::span[@aria-labelledby='select2-Dropdown-arialabel-container']");
        public static readonly By YesDropdownElement = By.XPath("//span[@class='select2-results']//li[contains(text(), 'Yes')]");
        public static readonly By SecondParentInformation = By.XPath("//h2//b[contains(text(), 'Second Parent Information')]");
        public static readonly By FirstNameInputSecond = By.XPath("//*[@id='Name1-li']//input[@elname='First']");
        public static readonly By LastNameInputSecond = By.XPath("//*[@id='Name1-li']//input[@elname='Last']");
        public static readonly By EmailInputSecond = By.Id("Email1-arialabel");
        public static readonly By PhoneInputSecond = By.Id("PhoneNumber1");
        public static readonly By Checkboxes = By.XPath("//li[@id='Checkbox-li']//em[@class='cusChoiceEm']");
        public static readonly By CalendarElement = By.XPath("//div[@class='calendarCont']//input[@name='Date']");
        public static readonly By NextCalendarElement = By.XPath("//a[@class='ui-datepicker-next ui-corner-all'][@data-handler='next']");
        public static readonly By Days = By.XPath("//div[@id='ui-datepicker-div']//tbody//td[@data-handler='selectDay']");
        public static readonly By NextButtonElement = By.XPath("//ul[@page_no='1']//button[@elname='next']");
    }
        public static class StudentPageLocators
    {
        public static readonly By StudentPageLabelElement = By.XPath("//li[@page_no='2'][@id='Section3-li']//h2[@class='advLabelName']//b");
    }
 }
