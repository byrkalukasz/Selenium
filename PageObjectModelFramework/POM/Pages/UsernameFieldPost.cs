using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM
{
    class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/article/div/p/a")]
        public IWebElement LoginFormLink { get; set; }
    }
}
