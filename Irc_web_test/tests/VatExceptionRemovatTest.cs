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
            if (app.VatException.VatExceptionIsNotCreated())
            {
                VatAccountData newaccount = new VatAccountData("123456781");
                newaccount.Account20 = "123456782";
                app.VatException.Create(newaccount);

            }
            app.VatException.Remove();



           

           
        }

    }
}
