using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace POM
{
    class ValidLogin
    {
        IAlert alert;
        public ValidLogin()
        {
        }
        [SetUp]
        public void Initialize()
        {
            Actions.InitialDriver();
        }
        [Test]
        public void SuccesLogin()
        {
            Navigation.LoginFormThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.username, Config.Credentials.Valid.password);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.SuccesLogin, alert.Text);
            Screenshot SuccesLogin = ((ITakesScreenshot)Driver.webDriver).GetScreenshot();
            SuccesLogin.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshoot\SuccesLogin.png", ScreenshotImageFormat.Png);
            alert.Accept();
        }
        [TearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
