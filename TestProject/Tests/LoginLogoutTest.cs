using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Pages;

namespace TestProject
{
    [TestFixture]
    public class LoginLogoutTest
    {
        IWebDriver driver = null;
        [Test]
        public void LoginLogout()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Url = "https://www.amazon.in/";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.ViewOrders(driver);
            logoutPage.Logout(driver);
            driver.Close();
        }    
    }
}
