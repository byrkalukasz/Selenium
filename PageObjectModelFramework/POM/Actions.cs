using OpenQA.Selenium.Firefox;

namespace POM
{
    public static class Actions
    {

        public static void InitialDriver()
        {
            Driver.webDriver = new FirefoxDriver();
            Driver.webDriver.Navigate().GoToUrl(Config.BaseUrl);
        }
        public static void FillLoginForm(string Login, string Password)
        {
            LoginFormPost loginFormPost = new LoginFormPost();
            loginFormPost.UsernameField.Clear();
            loginFormPost.UsernameField.SendKeys(Login);
            loginFormPost.PasswordField.Clear();
            loginFormPost.PasswordField.SendKeys(Password);
            loginFormPost.RepeatPasswordField.Clear();
            loginFormPost.RepeatPasswordField.SendKeys(Password);
            loginFormPost.LoginButton.Click();
        }
    }
}