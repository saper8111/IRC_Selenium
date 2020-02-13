﻿using OpenQA.Selenium;
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
            //manager.Navigation.OpenHomePage();  //данные методы можно удалить
            //Thread.Sleep(1000); //данные методы можно удалить

            manager.Navigation.GoToVATExceptionListPage();
            //Thread.Sleep(1000);
            InitRecordCreation();
            FillRecordForm(account);
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

        /*  из проекта "WebAddressbookTest"


         public List<ContactData> GetContactList()
    {
        if(contactCach == null)
        {
            contactCach = new List<ContactData>();
            manager.Navigation.OpenHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("tr[name = 'entry']"));
            foreach (IWebElement element in elements)
            {
                ContactData contact = new ContactData(element.Text);
                element.FindElements(By.XPath(".//td"));
                contact.Firstname = element.FindElement(By.XPath(".//td[3]")).Text;
                contact.Lastname = element.FindElement(By.XPath(".//td[2]")).Text;

                contactCach.Add(contact);
            }
        }







         */




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
