using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    public class LoginPage
    {
        public IWebDriver driver=null;
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id,Using = "ap_email")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement lnkSignin { get; set; }
  
        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement btnContinue { get; set; }

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement btnLogin { get; set; }


        public void Login()
        {
            lnkSignin.Click();
            Thread.Sleep(3000);
            txtUserName.SendKeys("harikk2001@gmail.com");
            btnContinue.Click();
            Thread.Sleep(2000);
            txtPassword.SendKeys("Kanuparthi@1");
            btnLogin.Click();
            Thread.Sleep(6000);            
        }
    }
}
