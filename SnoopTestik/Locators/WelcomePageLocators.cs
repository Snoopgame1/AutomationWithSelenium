using OpenQA.Selenium;

namespace SnoopTestik.Locators
{
    class WelcomePageLocators
    {
        public static By _enterButton { get; set; } = By.XPath("//a[normalize-space()='Enter the Store']");
    }
}
