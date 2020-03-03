using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

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
            //manager.Navigation.OpenHomePage();
            manager.Navigation.GoToVATExceptionListPage();
            //SearchAddRecord();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//td[9]")).Click();

        }

        //public void AddFailResultInTestRail()
        //{
        //    APIClient client = new APIClient("https://dhlru.testrail.io/");
        //    client.User = "Vyacheslav.Kozhurov@dhl.ru";
        //    client.Password = "1xVixA7Ug7q4Ys1di36M";
        //    JObject c = (JObject)client.SendGet("get_case/2618");
        //    Console.WriteLine(c["title"]);
        //    var data = new Dictionary<string, object>
        //    {
        //        {"status_id", "5" },
        //        {"comment", "Не УРА" }
        //    };
        //    client.SendPost("add_result_for_case/294/2618", data);
        //}

        //public void AddPassResultInTestRail()
        //{
        //    APIClient client = new APIClient("https://dhlru.testrail.io/");
        //    client.User = "Vyacheslav.Kozhurov@dhl.ru";
        //    client.Password = "1xVixA7Ug7q4Ys1di36M";
        //    JObject c = (JObject)client.SendGet("get_case/2618");
        //    Console.WriteLine(c["title"]);
        //    var data = new Dictionary<string, object>
        //    {
        //        {"status_id", "1" },
        //        {"comment", "УРА" }
        //    };
        //    client.SendPost("add_result_for_case/294/2618", data);
        //}

        public bool VatExceptionIsCreated()
        {
            return IsElementPresent(By.XPath("//td[1]"));
        }

        public VatExceptionHelper SearchAddRecord()
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("123456780");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
            return this;
        }

        public VatExceptionHelper SearchAddAnotherRecord()
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("111111111");
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
            
            //manager.Navigation.OpenHomePage();
            //Thread.Sleep(1000);
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
