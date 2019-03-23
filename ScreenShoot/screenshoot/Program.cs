using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System.IO;

namespace screenshoot
{
    class Program
    {
        static void Main()
        {
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("http://testing.todvachev.com/");

            Screenshot screenshot = ((ITakesScreenshot)webDriver).GetScreenshot();

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screen");

            screenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screen\screen.png", ScreenshotImageFormat.Png);

            webDriver.Quit();
            
        }
    }
}
