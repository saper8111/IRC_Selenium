using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace WebIrcTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "https://test.irc.ru.dhl.com/calculation";


        }
    }

    
}
