using NUnit.Framework;
using TestAutomationProject.PageObject;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    class BaseTest
    {
        protected SeleniumDriver _selenium;
        protected Pages Pages;
        
        public BaseTest()
        {
            _selenium = new SeleniumDriver();
            Pages = new Pages(_selenium.Driver);
        }

        [OneTimeTearDown]
        public void PostConditions()
        {
            _selenium.CloseDriver();
        }
    }
    
}
