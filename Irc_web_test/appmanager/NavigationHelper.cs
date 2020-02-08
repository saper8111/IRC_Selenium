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
            driver.Navigate().GoToUrl("https://demo.irc.ru.dhl.com/calculation");
        }

        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("Calculate")).Click();
        }

        public void GoToVATExceptionListPage()
        {
            driver.FindElement(By.LinkText("Vat Exception List")).Click();
        }
    }
}
