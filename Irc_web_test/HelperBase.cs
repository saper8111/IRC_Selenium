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
        protected IWebDriver driver;
        protected string baseURL;

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HelperBase(IWebDriver driver, string baseURL) : this(driver)
        {
            this.baseURL = baseURL;
        }
    }



}
