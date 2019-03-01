using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class StartingPoint
{
    static IWebDriver firefox = new FirefoxDriver();
    static IWebElement radiobutton;

    static void Main()
    {
        string radiobuttonURL = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string[] button = { "1", "3", "5" };
        firefox.Navigate().GoToUrl(radiobuttonURL);
        Console.Clear();
        for (int i = 0; i < button.Length; i++)
        {
            try
            {
                radiobutton = firefox.FindElement(By.CssSelector(".entry-content > form:nth-child(2) > p:nth-child(6) > input:nth-child(" + button[i] + ")"));
            }
            catch (NoSuchElementException)
            {
                RedMassage("I can't see radio button");
                goto quit;
            }
            if (radiobutton.GetAttribute("checked") == "true")
            {
                GreenMassage("Radio button " + i + " is Check");
            }
            else
            {
                RedMassage("Radio button " + i + " is uncheck");
            }
        }
        Thread.Sleep(5000);
    quit:
        firefox.Quit();
    }
    static private void GreenMassage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static private void RedMassage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

