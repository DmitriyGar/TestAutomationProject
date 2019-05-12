using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.PageObject;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    class BaseTest
    {
        protected SeleniumDriver _selenium;
        protected readonly MainPage mainPage;
        protected readonly SignInBlock signInBlock;
        public BaseTest()
        {
            _selenium = new SeleniumDriver();
            if (mainPage == null)
                mainPage=new MainPage(_selenium.Driver);
            if (signInBlock == null)
                signInBlock = new SignInBlock(_selenium.Driver);
        }
        [OneTimeTearDown]
        public void PostConditions()
        {
            _selenium.CloseDriver();
        }
    }
    
}
