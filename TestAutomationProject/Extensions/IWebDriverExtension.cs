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
                Debug.WriteLine("in while");
                element = driver.FindElements(locator).FirstOrDefault();
                if (wait.Elapsed > TimeSpan.FromSeconds(5) && element == null)
                {
                    throw new NoSuchElementException($"Locator not found: {locator}");
                }
                Thread.Sleep(500);
            }
            return element;
        }

        public static string GetTextElement(this IWebDriver driver,By element)
        {
            return driver.FindElements(element).FirstOrDefault()?.Text.Trim();
        }
    }
}
