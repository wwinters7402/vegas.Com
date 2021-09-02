using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vegas.Com.Pages
{
    public class LoginPage
    {

        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        //UI Elements
        public IWebElement signIn => WebDriver.FindElement(By.XPath("//button[normalize-space()='Sign in']"));
        public IWebElement eMailAddress => WebDriver.FindElement(By.XPath("//input[@id='id1']"));
        public IWebElement passWord => WebDriver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement signIn2 => WebDriver.FindElement(By.XPath("//button[normalize-space()='Sign in']"));

        //Methods
        public void ClickLogin1() => signIn.Click();


    }
}
