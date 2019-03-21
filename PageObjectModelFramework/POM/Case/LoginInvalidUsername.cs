using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

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
            alert.Accept();
        }
        [TestCase]
        public void UsernameMoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenChar, Config.Credentials.Valid.password);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.InvalidUsername, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
