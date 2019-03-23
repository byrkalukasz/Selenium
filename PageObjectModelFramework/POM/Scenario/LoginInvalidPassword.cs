using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

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
            Screenshot PasswordLessThan5Char = ((ITakesScreenshot)Driver.webDriver).GetScreenshot();
            PasswordLessThan5Char.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshoot\PassLessThan5Char.png", ScreenshotImageFormat.Png);
            alert.Accept();
        }
        [TestCase]
        public void PasswordMoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.username, Config.Credentials.Invalid.Password.MoreThan12Chharacters);
            Screenshot PasswordMoreThan12Char = ((ITakesScreenshot)Driver.webDriver).GetScreenshot();
            PasswordMoreThan12Char.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshoot\PassMoreThan12Char.png", ScreenshotImageFormat.Png);
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
