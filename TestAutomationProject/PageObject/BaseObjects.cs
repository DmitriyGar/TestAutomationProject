using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.PageObject
{
    class BaseObjects
    {
        protected BaseObjects(IWebDriver driver)
        {
            Driver = driver;

        }
        protected readonly IWebDriver Driver;

        protected string GetTextElement(By element)
        {
            return Driver.FindElements(element).FirstOrDefault()?.Text.Trim();
        }

        public IWebElement GetElement(By locator)
        {
            return Driver.FindElements(locator).FirstOrDefault();
        }
    }
}
