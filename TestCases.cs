using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using vegas.Com.BaseClass;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.IO;

namespace vegas.Com.BaseClass
{
    [TestClass]
    public class TestCases : BaseTest
    {
        //private object wait;

        [TestMethod]
        [TestCategory("Search For Hotels")]
        [TestCategory("Author Woodrow Winters")]
        public void SearchForHotels()
        {

            IWebElement hotels = driver.FindElement(By.XPath("//a[@class='_3MeIO'][normalize-space()='Hotels']"));
            hotels.Click();

            IWebElement checkIn = driver.FindElement(By.XPath("//input[@value='08/25/2021']"));
            checkIn.Clear();
            checkIn.SendKeys("04/13/2021");

            IWebElement checkOut = driver.FindElement(By.XPath("//input[@value='08/26/2021']"));
            checkOut.Clear();
            checkOut.SendKeys("04/18/2021");

            IWebElement searchHotels = driver.FindElement(By.XPath("//span[normalize-space()='SEARCH HOTELS']"));
            searchHotels.Click();

            IWebElement searchByName = driver.FindElement(By.XPath("//input[@aria-label='Search By Name']"));
            searchByName.SendKeys("Strat");

            IWebElement stratName = driver.FindElement(By.XPath("//b[normalize-space()='STRAT']"));
            stratName.Click();

            IWebElement searchByNameBtn = driver.FindElement(By.XPath("//div[@class='-lbU9']//hr[1]"));
            searchByNameBtn.Click();





        }

        [TestMethod]
        [TestCategory("SignIn")]
        [TestCategory("Author Woodrow Winters")]
        public void SignInVegasCom()
        {
            IWebElement signIn = driver.FindElement(By.XPath("//a[@class='_3darT']"));
            signIn.Click();


            IWebElement email = driver.FindElement(By.Id("id1"));
            email.Clear();
            email.SendKeys("woodrowtest1@gmail.com");

            IWebElement passWord = driver.FindElement(By.CssSelector("input[name='password']"));
            //passWord.Clear();
            passWord.SendKeys("Lacie@7402");

            IWebElement singIn2 = driver.FindElement(By.XPath("//button[normalize-space()='Sign in']"));
            singIn2.Click();




            }


        }
    }

