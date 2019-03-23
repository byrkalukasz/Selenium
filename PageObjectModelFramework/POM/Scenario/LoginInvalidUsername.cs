using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace POM
{
    class LoginInvalidUsername
    {
        IAlert alert;
        public LoginInvalidUsername()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitialDriver();
            Navigation.LoginFormThroughMenu();
        }
        [TestCase]
        public void UsernameLessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourChar, Config.Credentials.Valid.password);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.InvalidUsername, alert.Text);
            Screenshot UsernameLessThan5Char = ((ITakesScreenshot)Driver.webDriver).GetScreenshot();
            UsernameLessThan5Char.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshoot\UsernameLessThan5Char.png", ScreenshotImageFormat.Png);
            alert.Accept();
        }
        [TestCase]
        public void UsernameMoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenChar, Config.Credentials.Valid.password);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.InvalidUsername, alert.Text);
            Screenshot UsernameMoreThan12Char = ((ITakesScreenshot)Driver.webDriver).GetScreenshot();
            UsernameMoreThan12Char.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshoot\UsernameMoreThan12Char.png", ScreenshotImageFormat.Png);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
