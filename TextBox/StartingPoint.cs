using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class StartingPoint
{
    static IWebElement textbox;
    static IWebDriver firefox = new FirefoxDriver();
    static void Main()
    {
        string textboxURL = "http://testing.todorvachev.com/special-elements/text-input-field/";

        firefox.Navigate().GoToUrl(textboxURL);

        Console.Clear();
        try
        {
            textbox = firefox.FindElement(By.XPath("/html/body/div/div[2]/div/article/div/p[3]/input"));
            if (textbox.Displayed)
            {
                GreenMassage("I can see Text Box element on page");
            }
        }
        catch(NoSuchElementException)
        {
            RedMassage("I can't find Text Box element on web page");
        }

        textbox.SendKeys("testing key");
        Console.WriteLine(textbox.GetAttribute("value"));
        Console.WriteLine("Max length : " + textbox.GetAttribute("maxlength"));
        Thread.Sleep(50000);
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

