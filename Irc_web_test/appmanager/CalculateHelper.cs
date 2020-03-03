using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
            FillAWBNumber(awb);
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
            new SelectElement(driver.FindElement(By.Id("contract"))).SelectByText("NO");
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
