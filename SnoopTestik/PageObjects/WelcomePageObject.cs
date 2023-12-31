﻿using OpenQA.Selenium;
using SnoopTestik.Locators;

namespace SnoopTestik.PageObjects
{
    class WelcomePageObject
    {
        private IWebDriver _webDriver;
        public WelcomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public MainMenuPageObject EnterShop()
        {
            _webDriver.FindElement(WelcomePageLocators._enterButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
