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
            manager.Navigation.OpenHomePage();  //данные методы можно удалить
            Thread.Sleep(1000); //данные методы можно удалить
            manager.Navigation.GoToVATExceptionListPage();
            Thread.Sleep(1000);
            InitRecordCreation();
            FillRecordForm(account);
            SaveRecordCreation();
            Thread.Sleep(1000);
            return this;
        }

        public bool VatExceptionIsNotCreated()
        {
            return !IsElementPresent(By.XPath("//td[1]"));
        }

        public void  Remove()
        {
            manager.Navigation.OpenHomePage();
            manager.Navigation.GoToVATExceptionListPage();
            SearchAddRecord();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//td[9]")).Click();

        }

        public VatExceptionHelper SearchAddRecord()
        {
            //driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/calculation");
            //Thread.Sleep(1000);
            //driver.FindElement(By.LinkText("Vat Exception List")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("123456780");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
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

        public List<VatAccountData> GetAccountList()
        {
            manager.Navigation.OpenHomePage();
            Thread.Sleep(1000);
            manager.Navigation.GoToVATExceptionListPage();
            Thread.Sleep(1000);
            manager.VatException.SearchAddRecord();
            Thread.Sleep(1000);
            List<VatAccountData> accounts = new List<VatAccountData>();

            // получить список аккаунтов
            ICollection<IWebElement> elements = driver.FindElements(By.XPath(".//td[2]"));
            // строим цикл
            foreach (IWebElement element in elements)
            {
                accounts.Add(new VatAccountData(element.Text));
            }

            return accounts;
        }



    }
}
