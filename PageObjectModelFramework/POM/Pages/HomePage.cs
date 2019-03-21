using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace POM
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.webDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/article/header/h1")]
        public IWebElement Headline { get; set; }
    }
}
