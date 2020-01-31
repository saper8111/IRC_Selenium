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
            navigationHelper.OpenHomePage();
            //AWBData data = new AWBData();
            //data.AWB_number = "7281956765";
            calculateHelper.FillAWBNumber(new AwbData("7281956765"));
            Thread.Sleep(1000);
            calculateHelper.ChoiseVAT();
            calculateHelper.InitCalculate();
            Thread.Sleep(10000);
        }

        
    }
}
