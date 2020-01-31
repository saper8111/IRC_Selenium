using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIrcTests
{
    public class VatExceptionHelper:HelperBase
    {
        public VatExceptionHelper(IWebDriver driver)
            :base(driver) {}

        public void InitRecordCreation()
        {
            driver.FindElement(By.LinkText("Add New Record")).Click();
        }

        public void FillRecordForm(VatAccountData account)
        {
            driver.FindElement(By.Id("account0")).Click();
            driver.FindElement(By.Id("account0")).SendKeys(account.Account0);
            driver.FindElement(By.Id("account20")).Click();
            driver.FindElement(By.Id("account20")).SendKeys(account.Account20);
            driver.FindElement(By.Id("export")).Click();
            driver.FindElement(By.Id("import")).Click();
        }

        public void SaveRecordCreation()
        {
            driver.FindElement(By.XPath("//button[@type=\'button\']")).Click();
            driver.FindElement(By.XPath("//button")).Click();

        }
    }
}
