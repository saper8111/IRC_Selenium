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
    public class VatExceptionRemovatTest:TestBase
    {
        [Test]

        public void VatExceptionRemovalTest()
        {
            app.Navigation.GoToVATExceptionListPage();
            

            if (app.VatException.VatExceptionIsNotCreated())
            {
                VatAccountData newaccount = new VatAccountData("123456780");
                newaccount.Account20 = "123456710";
                app.VatException.Create(newaccount);
            }

            Assert.IsFalse(app.VatException.VatExceptionIsNotCreated());

            List<VatAccountData> oldAccount = app.VatException.GetAccountList();

            app.VatException.Remove();

            List<VatAccountData> newAccount = app.VatException.GetAccountList();

            oldAccount.RemoveAt(0);

            Assert.AreEqual(oldAccount, newAccount);




        }
        

    }
}
