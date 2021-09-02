using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;

namespace vegas.Com.BaseClass
{
    public class BaseTest
    {

        public IWebDriver driver;

        [TestInitialize]

        public void Open()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://vegas.com");
            //driver.Navigate().GoToUrl("https://facebook.com");

            driver.Manage().Window.Maximize();

           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TestCleanup]
        public void Close()
        {
            //driver.Quit();

        }
        
    }


}

