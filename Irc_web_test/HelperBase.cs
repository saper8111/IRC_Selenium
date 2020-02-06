﻿using System;
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
            //this.driver = driver;
            this.manager = manager;
            driver = manager.Driver;
        }

    }
}
