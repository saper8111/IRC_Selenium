using System;
using OpenQA.Selenium;
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

        protected NavigationHelper navigationHelper;
        protected CalculateHelper calculateHelper;
        protected VatExceptionHelper vatExceptionHelper;

        private static ApplicationManager instance;

        private ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "https://test.irc.ru.dhl.com/calculation";

            calculateHelper = new CalculateHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            vatExceptionHelper = new VatExceptionHelper(this);
        }

        public static ApplicationManager GetInstance()
        {
            if(instance == null)
            {
                instance = new ApplicationManager();
            }
            return instance;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
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
