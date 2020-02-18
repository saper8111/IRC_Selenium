using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebIrcTests
{
    public class NavigationHelper: HelperBase
    {


        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
        }
            



        public void OpenHomePage()
        {
            // добавить проверку того, что если пользователь уже находится на данной
            // странице, то переходить никуда не надо.
            driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/calculation");
        }

        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("Calculate")).Click();
        }

        public void GoToVATExceptionListPage()
        {
            // добавить проверку того, что если пользователь уже находится на данной
           // странице, то переходить никуда не надо.
            driver.FindElement(By.LinkText("Vat Exception List")).Click();
        }

        public void SearchAddRecord()
        {
            manager.Navigation.OpenHomePage();
            manager.Navigation.GoToVATExceptionListPage();
            //driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/vat-exception-list");
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("123456789");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
        }


    }
}
