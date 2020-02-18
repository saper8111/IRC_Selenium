using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace WebIrcTests
{
    [TestFixture]
    public class VatExceptionCreationTests:TestBase
    {
       
        [Test]
        public void VatExceptionCreationTest()
        {
      
            

            VatAccountData account = new VatAccountData("123456789");
            account.Account20 = "123456780";

            List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

            app.VatException.Create(account);
            
            List<VatAccountData> newAccounts = app.VatException.GetAccountList();
            Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
        }

        /*
         
         
         driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/vat-exception-list");
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("123456789");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
         
         
         
         
         */

    }


}
