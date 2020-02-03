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
    public class NavigationHelper:HelperBase
    {

<<<<<<< HEAD
        public NavigationHelper(IWebDriver driver)
            : base(driver)
        {
        }
            
=======
        public NavigationHelper(IWebDriver driver, string baseURL)
            :base(driver,baseURL){}
>>>>>>> d29625c942ef03880e6663d9a70ed6e34a04c065

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
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
