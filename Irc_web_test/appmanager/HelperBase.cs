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
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;


        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        // продумать где еще данный метод можно использовать
        public void Type(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
        // продумать где еще данный метод можно использовать

    }
}
