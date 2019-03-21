﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM
{
    class TestCasePage
    {
        public TestCasePage()
        {
            PageFactory.InitElements(Driver.webDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/article[3]/div[2]/header/h3/a")]
        public IWebElement UsernameFiels { get; set; }
    }
}