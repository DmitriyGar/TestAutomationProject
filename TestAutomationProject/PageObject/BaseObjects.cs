using OpenQA.Selenium;

namespace TestAutomationProject.PageObject
{
    class BaseObjects
    {
        protected BaseObjects(IWebDriver driver)
        {
            Driver = driver;

        }
        protected readonly IWebDriver Driver;

               
    }
}
