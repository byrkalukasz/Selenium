using OpenQA.Selenium; //podstawowe biblioteki selenium
using OpenQA.Selenium.Firefox; //biblioteki przeglądarki
using System; //Biblioteki systemowe
using System.Threading; 

class StartingPoint
{
    static void Main()
    {   
        //Deklaracja zmiennych
        string ID_url = "http://testing.todorvachev.com/selectors/id/";  //deklaracja ardesu
        string Name_url = "http://testing.todvachev.com/selectors/name/"; //deklaracja adresu 2
        string ID = "testImage"; // deklaracja nazwy poszukiwanego elementu
        string Name = "myName"; //deklaracje drugiej zmiennej
        int count, positive, negative; //Zmienne do przechowywania informacji o krokach
        //Zerowanie zmiennych
        count = 0;
        positive = 0;
        negative = 0;
        //ciało programu
        IWebDriver webDriver = new FirefoxDriver(); //inicjalizacja i wskazanie przeglądarki
        webDriver.Navigate().GoToUrl(ID_url); //nakaz wejscia na podany aders
        IWebElement element = webDriver.FindElement(By.Id(ID)); //deklaracja poszukiwanego elementu
        Console.Clear();
        if (element.Displayed) //warunek sprawdzający czy element jest widoczny.
        {
            GreenMessage("Yes, I can see it!");
            count++;
            positive++;
        }
        else
        {
            RedMessage("Nope, its not there!");
            count++;
            negative++;
        }
        webDriver.Navigate().GoToUrl(Name_url);
        IWebElement webElement = webDriver.FindElement(By.Name(Name));
        if (webElement.Displayed) //warunek sprawdzający czy element jest widoczny.
        {
            GreenMessage("Yes, I can see it!");
            count++;
            positive++;
        }
        else
        {
            RedMessage("Nope, its not there!");
            count++;
            negative++;
        }
        webDriver.Quit();
        BlueMassage("Wszystkie kroki " + count);
        GreenMessage("Pozytywne kroki " + positive);
        RedMessage("Negatywne kroki " + negative);
        Console.ReadKey(); // zakonczenie po wcisnieciu klawisza
    }
    private static void RedMessage(string message) //metoda na zielony tekst
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void GreenMessage(string message) //metoda na czerwony tekst
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void BlueMassage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
