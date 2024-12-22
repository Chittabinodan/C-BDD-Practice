using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class GoogleSearch
    {
        private IWebDriver driver;
        [Given(@"User opens Chrome Browser")]
        public void GivenUserOpensChromeBrowser()
        {
            driver = new ChromeDriver();
        }

        [When(@"User opens Google")]
        public void WhenUserOpensGoogle()
        {
            driver.Url = "https://www.google.com";
        }

        [Then(@"User can search for '([^']*)'")]
        public void ThenUserCanSearchFor(string chittabinodan)
        {
            chittabinodan = "Chittabinodan";
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(chittabinodan);
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.Close();
        }

    }
}
