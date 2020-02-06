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
            app.Navigation.OpenHomePage();
            app.Calculate
                .FillAWBNumber(new AwbData("7281956765"))
                        //Thread.Sleep(1000) // данную команду перенести в другой класс
                .ChoiseVAT()
                .InitCalculate();
                       // Thread.Sleep(10000); // данную команду перенести в другой класс
        }


    }
}
