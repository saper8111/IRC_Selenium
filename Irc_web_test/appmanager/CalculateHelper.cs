using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebIrcTests
{
   public class CalculateHelper:HelperBase
    {
        public CalculateHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public CalculateHelper NewCalculate(AwbData awb)
        {
            manager.Navigation.OpenHomePage();
            FillAWBNumber(new AwbData("7281956765"));
            Thread.Sleep(1000); 
            ChoiseVAT();
            InitCalculate();
            Thread.Sleep(10000); 

            return this;
        }



        public CalculateHelper FillAWBNumber(AwbData awb)
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            Type(By.XPath("//input[@type='text']"), awb.Awb_number);
            //driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(awb.Awb_number);
            return this;
        }

        public CalculateHelper ChoiseVAT()
        {
            driver.FindElement(By.Id("contract")).Click();
            new SelectElement(driver.FindElement(By.Id("contract"))).SelectByText("YES");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("contract")).Click();
            return this;
        }

        public CalculateHelper InitCalculate()
        {
            driver.FindElement(By.XPath("(//button[@type='button'])[2]")).Click();
            return this;
        }
    }
}
