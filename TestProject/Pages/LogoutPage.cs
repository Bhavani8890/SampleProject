using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    public class LogoutPage
    {
        public LogoutPage(IWebDriver driver2)
        {
            IWebDriver driver = driver2;
        }
        public void ViewOrders(IWebDriver driver)
        {
            Actions actions = new Actions(driver);

            IWebElement lnkAcntList = driver.FindElement(By.Id("nav-link-accountList"));
            actions.MoveToElement(lnkAcntList).Perform();

            IWebElement lnkYourOders = driver.FindElement(By.Id("nav_prefetch_yourorders"));
            lnkYourOders.Click();


            Thread.Sleep(3000);
        }
        public void Logout(IWebDriver driver)
        {
            Actions actions = new Actions(driver);

            IWebElement lnkAcntList1 = driver.FindElement(By.Id("nav-link-accountList"));
            Thread.Sleep(6000);
            actions.MoveToElement(lnkAcntList1).Perform();

            IWebElement lnkSignOut = driver.FindElement(By.Id("nav-item-signout"));
            lnkSignOut.Click();
        }
    }
}
