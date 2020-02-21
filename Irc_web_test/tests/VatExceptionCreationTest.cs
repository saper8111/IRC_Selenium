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
            VatAccountData account = new VatAccountData("123456780");
            account.Account20 = "123456710";

            List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

            app.VatException.Create(account);
            List<VatAccountData> newAccounts = app.VatException.GetAccountList();
            Assert.AreEqual(oldAccounts.Count + 2, newAccounts.Count);
            oldAccounts.Add(account);
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);
            if (oldAccounts != newAccounts)
            {
                Console.Write("Error");
            }

        }

        /**/
        
    }


}
