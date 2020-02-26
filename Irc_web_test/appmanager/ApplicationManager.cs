using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WebIrcTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected string testrailURL;

        protected NavigationHelper navigationHelper;
        protected CalculateHelper calculateHelper;
        protected VatExceptionHelper vatExceptionHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "https://test.irc.ru.dhl.com/calculation";
           

            calculateHelper = new CalculateHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            vatExceptionHelper = new VatExceptionHelper(this);
        }

        ~ApplicationManager() // диструктор
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }



        public static ApplicationManager GetInstance()
        {
            if(!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }


        public NavigationHelper Navigation
        {
            get
            {
                return navigationHelper;
            }
        }

        public CalculateHelper Calculate
        {
            get
            {
                return calculateHelper;
            }
        }

        public VatExceptionHelper VatException
        {
            get
            {
                return vatExceptionHelper;
            }
        }
    }

    
}
