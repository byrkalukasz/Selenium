using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

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
            alert.Accept();
        }
        [TearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
