using opencart2.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace opencart2
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            loginpageobjects lp = new loginpageobjects(driver);
             driver.Navigate().GoToUrl("https://demo.opencart.com/");

            /* driver.FindElement(By.LinkText("My Account")).Click();
             driver.FindElement(By.LinkText("Login")).Click();
             driver.FindElement(By.Id("input-email")).SendKeys("ramya");
             driver.FindElement(By.Id("input-password")).SendKeys("ramya");
             driver.FindElement(By.XPath("//button[@type='submit']")).Click();*/
            lp.clickonmyaccount();
            lp.clickonloginlink();
            lp.enterusername();
            lp.enterpassword();
            lp.clickonsubmitbutton();
            driver.Quit();
            Assert.Pass();
        }
    }
}