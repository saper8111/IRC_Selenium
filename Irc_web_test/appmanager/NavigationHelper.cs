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
            if(driver.Url == "https://test.irc.ru.dhl.com/calculation")
            {
                return;
            }
         
            driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/calculation");
        }

        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("Calculate")).Click();
        }

        public void GoToVATExceptionListPage()
        {
            if (driver.Url == "https://test.irc.ru.dhl.com/vat-exception-list"
                && IsElementPresent(By.XPath("//h1[@class='title']")))
            {
                return;
            }

            driver.Navigate().GoToUrl("https://test.irc.ru.dhl.com/vat-exception-list");
        }



        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
