using NUnit.Framework;
using OpenQA.Selenium;


namespace POM
{
    class FailTest
    {
        IAlert alert;
        public FailTest()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitialDriver();
            Navigation.LoginFormThroughMenu();
        }
        [Test]
        public void PasswordLessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.username, Config.Credentials.Invalid.Password.LessThan5Characters);
            alert = Driver.webDriver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMassage.SuccesLogin, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.webDriver.Quit();
        }
    }
}
