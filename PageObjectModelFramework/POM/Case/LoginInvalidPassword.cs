using NUnit.Framework;
using OpenQA.Selenium;

namespace POM
{
    class LoginInvalidPassword
    {
        IAlert alert;
        public LoginInvalidPassword()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitialDriver();
            Navigation.LoginFormThroughMenu();
        }
        [TestCase]
        public void PasswordLessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.username, Config.Credentials.Invalid.Password.LessThan5Characters);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.InvalidPassword, alert.Text);
            alert.Accept();
        }
        [TestCase]
        public void PasswordMoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.username, Config.Credentials.Invalid.Password.MoreThan12Chharacters);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.InvalidPassword, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
