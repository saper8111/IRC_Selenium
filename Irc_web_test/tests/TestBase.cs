using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebIrcTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://test.irc.ru.dhl.com/calculation";
            verificationErrors = new StringBuilder();

        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        protected void InitCalculate()
        {
            driver.FindElement(By.XPath("(//button[@type='button'])[2]")).Click();
        }

        protected void ChoiseVAT()
        {
            driver.FindElement(By.Id("contract")).Click();
            new SelectElement(driver.FindElement(By.Id("contract"))).SelectByText("YES");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("contract")).Click();
        }

        protected void FillAWBNumber(AwbData awb)
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(awb.Awb_number);
        }

        protected void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        protected void GoToHomePage()
        {
            driver.FindElement(By.LinkText("Calculate")).Click();
        }

        protected void SaveRecordCreation()
        {
            driver.FindElement(By.XPath("//button[@type=\'button\']")).Click();
            driver.FindElement(By.XPath("//button")).Click();

        }

        protected void FillRecordForm(VatAccountData account)
        {
            driver.FindElement(By.Id("account0")).Click();
            driver.FindElement(By.Id("account0")).SendKeys(account.Account0);
            driver.FindElement(By.Id("account20")).Click();
            driver.FindElement(By.Id("account20")).SendKeys(account.Account20);
            driver.FindElement(By.Id("export")).Click();
            driver.FindElement(By.Id("import")).Click();
        }

        

        protected void GoToVATExceptionListPage()
        {
            driver.FindElement(By.LinkText("Vat Exception List")).Click();
        }

        protected void InitRecordCreation()
        {
            driver.FindElement(By.LinkText("Add New Record")).Click();
        }


    }
}
