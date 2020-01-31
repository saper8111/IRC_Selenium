﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebIrcTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        private bool acceptNextAlert = true;

        protected NavigationHelper navigationHelper;
        protected VatExceptionHelper vatExceptionHelper;
        protected CalculateHelper calculateHelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://test.irc.ru.dhl.com/calculation";
            verificationErrors = new StringBuilder();

            navigationHelper = new NavigationHelper(driver);
            vatExceptionHelper = new VatExceptionHelper(driver);
            calculateHelper = new CalculateHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        

        

        

        

        

        


    }
}
