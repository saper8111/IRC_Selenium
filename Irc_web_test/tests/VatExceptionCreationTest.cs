﻿using System;
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
        public void VatExceptionCreationWidhValidDataTest()
        {
            VatAccountData account = new VatAccountData("123456780");
            account.Account20 = "123456710";

            List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

            app.VatException.Create(account);
            List<VatAccountData> newAccounts = app.VatException.GetAccountList();
            if (oldAccounts.Count + 1 != newAccounts.Count)
            {
                app.VatException.AddFailResultInTestRail();
            }
            else
            {
                app.VatException.AddPassResultInTestRail();
            }


            Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
            oldAccounts.Add(account);
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);

        }

        [Test]

        public void VatExceptionCreationWidhInvalidDataTest()
        {
            VatAccountData account = new VatAccountData("111111111");
            account.Account20 = "111111111";

            List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

            app.VatException.Create(account);
            List<VatAccountData> newAccounts = app.VatException.GetAccountList();
            if (oldAccounts.Count + 1 != newAccounts.Count)
            {
                app.VatException.AddFailResultInTestRail();
            }
            else
            {
                app.VatException.AddPassResultInTestRail();
            }


            Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
            oldAccounts.Add(account);
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);

        }


    }


}
