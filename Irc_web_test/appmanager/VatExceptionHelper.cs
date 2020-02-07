using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebIrcTests
{
    public class VatExceptionHelper:HelperBase
    {
        public VatExceptionHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public VatExceptionHelper Create(VatAccountData account)
        {
            manager.Navigation.OpenHomePage();
            manager.Navigation.GoToVATExceptionListPage();
            InitRecordCreation();
            FillRecordForm(new VatAccountData("123456789", "123456780"));
            SaveRecordCreation();
            Thread.Sleep(1000); 
            return this;
        }

        public VatExceptionHelper InitRecordCreation()
        {
            driver.FindElement(By.LinkText("Add New Record")).Click();
            return this;
        }

        public VatExceptionHelper FillRecordForm(VatAccountData account)
        {
            //By locator = By.Id("account0");
           // string text = account.Account0;

            TypeAccount(By.Id("account0"), account.Account0);
            TypeAccount(By.Id("account20"), account.Account20);
            TypeImort(By.Id("import"));
            TypeExport(By.Id("export"));

            //driver.FindElement(By.Id("account0")).Click();
            //driver.FindElement(By.Id("account0")).SendKeys(account.Account0);
            //driver.FindElement(By.Id("account20")).Click();
            //driver.FindElement(By.Id("account20")).SendKeys(account.Account20);
            //driver.FindElement(By.Id("export")).Click();
            //driver.FindElement(By.Id("import")).Click();
            return this;
        }
        // проверить, имеет ли смысл, именно здесь (в этом "помошнике"), делать приведенные ниже методы (начало).
        // может быть перенести данные методы в другой помошник (наприимер, CalculateHelper)?
        private void TypeExport(By by)
        {
            driver.FindElement(By.Id("export")).Click();
        }

        private void TypeImort(By by)
        {
            driver.FindElement(By.Id("import")).Click();
        }


        
        public void TypeAccount(By locator, string text)
        {
            driver.FindElement(locator).Click();
            driver.FindElement(locator).SendKeys(text);
        }

        //  проверить, имеет ли смысл делать приведенные ниже методы (конец)

        public VatExceptionHelper SaveRecordCreation()
        {
            driver.FindElement(By.XPath("//button[@type=\'button\']")).Click();
            driver.FindElement(By.XPath("//button")).Click();
            return this;

        }
    }
}
