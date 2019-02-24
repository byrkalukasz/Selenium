using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class StartingPoint
{
    static void Main()
    {
        string CssPath_url = "http://testing.todvachev.com/";
        string XPath_url = "http://testing.todvachev.com/category/test-cases/";
        string CSS = ".alignnone";
        string Xpath = "/html/body/div/div[2]/div/article[3]/div[1]/a/img";
        int count, positive, negative;
        count = 0;
        negative = 0;
        positive = 0;
        
        IWebDriver webDriver = new FirefoxDriver();
        webDriver.Navigate().GoToUrl(CssPath_url);

        IWebElement csselement = webDriver.FindElement(By.CssSelector(CSS));
        Console.Clear();
        if (csselement.Displayed)
        {
            GreenMessage("I can see it");
            count++;
            positive++;
        }
        else
        {
            RedMessage("Ican't see it");
            count++;
            negative++;
        }
        webDriver.Navigate().GoToUrl(XPath_url);
        IWebElement xpath = webDriver.FindElement(By.XPath(Xpath));
        if(xpath.Displayed)
        {
            GreenMessage("I can see it");
            count++;
            positive++;
        }
        else
        {
            RedMessage("I can't see it");
            count++;
            negative++;
        }
        BlueMessage("wykonane kroki " + count);
        GreenMessage("Pozytywne kroki " + positive);
        RedMessage("Negatywne kroki " + negative);

        webDriver.Quit();
        Console.ReadKey();
    }
    static private void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static private void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static private void BlueMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

