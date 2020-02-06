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
            app.VatException.Create(new VatAccountData("123456789", "123456780"));
        }

        
    }


}
