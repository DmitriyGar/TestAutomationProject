using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Utilities
{
    public class SeleniumDriver
    {
        private IWebDriver _driver;
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, GetChromeOptions());
                _driver.Manage().Cookies.DeleteAllCookies();
                return _driver;
            }
        }
        private ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-infobars");
            return options;
        }
        public void CloseDriver()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}
