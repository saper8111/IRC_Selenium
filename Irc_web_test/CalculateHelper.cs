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
        public CalculateHelper(IWebDriver driver)
            :base(driver){ }

        public void FillAWBNumber(AwbData awb)
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(awb.Awb_number);
        }

        public void ChoiseVAT()
        {
            driver.FindElement(By.Id("contract")).Click();
            new SelectElement(driver.FindElement(By.Id("contract"))).SelectByText("YES");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("contract")).Click();
        }

        public void InitCalculate()
        {
            driver.FindElement(By.XPath("(//button[@type='button'])[2]")).Click();
        }
    }
}
