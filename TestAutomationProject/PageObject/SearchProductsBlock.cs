using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomationProject.Extensions;

namespace TestAutomationProject.PageObject
{
    class SearchProductsBlock : BaseObjects
    {
        private By _searchField = By.Id("search_query_top");
        private By _searchResultsNumber = By.XPath("//span[@class='heading-counter']");
        private By _searchButton = By.XPath("//button[@name='submit_search']");
       

        public SearchProductsBlock(IWebDriver driver) : base(driver) { }

        public void SearchProducts(string product)
        {
            Driver.GetElement(_searchField).SendKeys(product);
                Driver.GetElement(_searchField).Submit();
            //Driver.GetElement(_searchButton).Click();
        } 



    }
}
