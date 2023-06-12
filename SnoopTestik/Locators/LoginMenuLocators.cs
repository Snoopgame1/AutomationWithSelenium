using OpenQA.Selenium;

namespace SnoopTestik.Locators
{
    class LoginMenuLocators
    {
        public static By _loginInput { get; set; } = By.Name("username");
        public static By _passwordInput { get; set; } = By.Name("password");
        public static By _loginButton { get; set; } = By.Name("signon");
        public static By _registerButton { get; set; } = By.XPath("//a[normalize-space()='Register Now!']");
    }
}
