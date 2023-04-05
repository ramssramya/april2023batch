using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencart2.pages
{
    public class loginpageobjects
    {
        private IWebDriver driver;
        public loginpageobjects(IWebDriver driver1)
        {
            driver = driver1;
        }

        public void clickonmyaccount()
        {
            driver.FindElement(By.LinkText("My Account")).Click();
        }
        public void clickonloginlink()
        {
            driver.FindElement(By.LinkText("Login")).Click();
        }
        public void enterusername()
        {
            driver.FindElement(By.Id("input-email")).SendKeys("ramya");
        }
        public void enterpassword()
        {
            driver.FindElement(By.Id("input-password")).SendKeys("ramya");
        }
        public void clickonsubmitbutton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
}
