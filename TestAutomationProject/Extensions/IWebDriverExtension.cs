using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TestAutomationProject.Extensions
{
    public static class IWebDriverExtension
    {
        public static IWebElement GetElement(this ISearchContext driver,By locator)
        {
            Stopwatch wait = Stopwatch.StartNew();
            IWebElement element = null;
            while (element == null)
            {
                Thread.Sleep(1000);
                element = driver.FindElements(locator).FirstOrDefault();
                if (wait.Elapsed > TimeSpan.FromSeconds(10) && element == null)
                {
                    throw new NoSuchElementException($"Locator not found: {locator}");
                } 
            }
            return element;
        }

        public static string GetTextElement(this IWebDriver driver,By element)
        {
            string getText = "";
            if (driver.GetElement(element).Text.Trim()!=null)
            getText = driver.GetElement(element).Text.Trim();
            return getText;
        }
    }
}
