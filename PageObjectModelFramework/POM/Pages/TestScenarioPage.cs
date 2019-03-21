using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM
{
    class TestScenarioPage
    {
        public TestScenarioPage()
        {
            PageFactory.InitElements(Driver.webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/article[1]/div[2]/header/h3/a")]
        public IWebElement LoginForm { get; set; }
    }
}
