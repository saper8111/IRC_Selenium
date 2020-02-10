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

        //public List<VatAccountData> GetAccountList()
        //{
        //    List<VatAccountData> Accounts = new List<VatAccountData>();
        //    manager.Navigation.GoToVATExceptionListPage();
        //    // получить список аккаунтов
        //    ICollection<IWebElement> elements = driver.FindElements(By.XPath(""));
        //    // строим цикл
        //    foreach (IWebElement element in elements)
        //    {
        //        //element.Text;
        //    }
            
        //    return Accounts;
        //}

        public VatExceptionHelper InitRecordCreation()
        {
            driver.FindElement(By.LinkText("Add New Record")).Click();

            // 
            return this;
        }

        public VatExceptionHelper FillRecordForm(VatAccountData account)
        {
            //By locator = By.Id("account0");
            //string text = account.Account0;


            driver.FindElement(By.Id("account0")).Click();
            Type(By.Id("account0"), account.Account0);
            //driver.FindElement(By.Id("account0")).Click();
            //driver.FindElement(By.Id("account0")).SendKeys(account.Account0);

            driver.FindElement(By.Id("account20")).Click();
            Type(By.Id("account20"), account.Account20);
            //driver.FindElement(By.Id("account20")).SendKeys(account.Account20);
            driver.FindElement(By.Id("export")).Click();
            driver.FindElement(By.Id("import")).Click();
            return this;
        }
        

        public VatExceptionHelper SaveRecordCreation()
        {
            driver.FindElement(By.XPath("//button[@type=\'button\']")).Click();
            driver.FindElement(By.XPath("//button")).Click();
            return this;

        }
    }
}
