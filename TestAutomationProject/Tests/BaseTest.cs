using NUnit.Framework;
using TestAutomationProject.PageObject;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    class BaseTest
    {
        protected SeleniumDriver _selenium = new SeleniumDriver();
        private Pages _pages;
        protected Pages Pages=>_pages ?? (new Pages(_selenium.Driver));
        
        [OneTimeTearDown]
        public void PostConditions()
        {
            //_selenium.CloseDriver();
        }
    }
    
}
