namespace POM
{
    public static class Navigation
    {
        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage testScenarioPage = new TestScenarioPage();

            menu.TestScenarios.Click();
            testScenarioPage.LoginForm.Click();

        }
        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasePage testCasePage = new TestCasePage();
            UsernameFieldPost usernameFieldPost = new UsernameFieldPost();

            menu.TestCases.Click();
            testCasePage.UsernameFiels.Click();
            usernameFieldPost.LoginFormLink.Click();
        }
    }
}
