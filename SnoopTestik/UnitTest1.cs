using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SnoopTestik.Data;
using SnoopTestik.PageObjects;

namespace SnoopTestik
{
    public class UnitTest1
    {
        private IWebDriver _webDriver;
        private readonly string _url = "https://petstore.octoperf.com/";
        public bool CheckAnything(string any) =>
            _webDriver.PageSource.Contains(any);
        [OneTimeSetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver(Environment.CurrentDirectory);
            _webDriver.Navigate().GoToUrl(_url);
        }
        [Test]
        public void Login()
        {
            WelcomePageObject login = new WelcomePageObject(_webDriver);
            login
                .EnterShop()
                .SignInButton()
                .LoginFill(TestData.Login, TestData.Password)
                .LoginSuccsess();
            Assert.True(CheckAnything(TestData.LoginSuccsess));
        }
        [Test]
        public void Registration()
        {
            WelcomePageObject reg = new WelcomePageObject(_webDriver);
            reg
                .EnterShop()
                .SignInButton()
                .RegisterButton()
                .RegistrationFill(TestData.RandomUserId, TestData.Password, TestData.Password, TestData.FirstName, TestData.LastName, TestData.Email,
                TestData.Phone, TestData.Address, TestData.City, TestData.State, TestData.Zip, TestData.Country)
                .RegisterButton();
            Assert.True(CheckAnything(TestData.RegisterSuccsess));
        }
        [TearDown]
        public void EndTest()
        {
            if (CheckAnything(TestData.LoginSuccsess) == true)
            {
                MainMenuPageObject main = new MainMenuPageObject(_webDriver);
                main.SignOutButton();
            }
            _webDriver.Navigate().GoToUrl(_url);
        }
    }
}
