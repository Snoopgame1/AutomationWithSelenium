using OpenQA.Selenium;
using SnoopTestik.Locators;

namespace SnoopTestik.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public LoginMenuPageObject SignInButton()
        {
            _webDriver.FindElement(MainMenuLocators._signInButton).Click();
            return new LoginMenuPageObject(_webDriver);
        }
        public LoginMenuPageObject SignOutButton()
        {
            _webDriver.FindElement(MainMenuLocators._signOutButton).Click();
            return new LoginMenuPageObject(_webDriver);
        }
    }
}
