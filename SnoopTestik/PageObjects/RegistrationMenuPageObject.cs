using OpenQA.Selenium;
using SnoopTestik.Locators;

namespace SnoopTestik.PageObjects
{
    class RegistrationMenuPageObject
    {
        private IWebDriver _webDriver;
        public RegistrationMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public RegistrationMenuPageObject RegistrationFill(string id, string password, string repeatPassword, string firstname,
            string lastname, string email, string phone, string address, string city, string state, string zip, string country)
        {
            _webDriver.FindElement(RegistrationMenuLocators._userId).SendKeys(id);
            _webDriver.FindElement(RegistrationMenuLocators._password).SendKeys(password);
            _webDriver.FindElement(RegistrationMenuLocators._repeatedPassword).SendKeys(repeatPassword);
            _webDriver.FindElement(RegistrationMenuLocators._firstName).SendKeys(firstname);
            _webDriver.FindElement(RegistrationMenuLocators._lastName).SendKeys(lastname);
            _webDriver.FindElement(RegistrationMenuLocators._email).SendKeys(email);
            _webDriver.FindElement(RegistrationMenuLocators._phone).SendKeys(phone);
            _webDriver.FindElement(RegistrationMenuLocators._address1).SendKeys(address);
            _webDriver.FindElement(RegistrationMenuLocators._address2).SendKeys(address);
            _webDriver.FindElement(RegistrationMenuLocators._city).SendKeys(city);
            _webDriver.FindElement(RegistrationMenuLocators._state).SendKeys(state);
            _webDriver.FindElement(RegistrationMenuLocators._zip).SendKeys(zip);
            _webDriver.FindElement(RegistrationMenuLocators._country).SendKeys(country);

            return new RegistrationMenuPageObject(_webDriver);
        }
        public MainMenuPageObject RegisterButton()
        {
            _webDriver.FindElement(RegistrationMenuLocators._regButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
