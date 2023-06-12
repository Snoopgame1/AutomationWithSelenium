using OpenQA.Selenium;

namespace SnoopTestik.Locators
{
    class MainMenuLocators
    {
        public static By _signInButton { get; set; } = By.XPath("//a[normalize-space()='Sign In']");
        public static By _signOutButton { get; set; } = By.XPath("//a[normalize-space()='Sign Out']");
    }
}
