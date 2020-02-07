using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebIrcTests
{
    [TestFixture]
    public class CalculateTests:TestBase
    {
        

        [Test]
        public void CalculateTest()
        {
            app.Calculate.NewCalculate(new AwbData ("7281956765"));
        }


    }
}
