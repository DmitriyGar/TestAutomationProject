using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Extensions;
using TestAutomationProject.Models;

namespace TestAutomationProject.PageObject
{
    class CreateAccountPage : BaseObjects

        {
            public CreateAccountPage(IWebDriver driver) : base(driver) { }

            private By _genderMr = By.Name("id_gender");
            private By _firstNameField = By.Id("customer_firstname");
            private By _lastNameField = By.Id("customer_lastname");
            private By _passwordField = By.Id("passwd");
            private By _addressField = By.Id("address1");
            private By _cityField = By.Id("city");
            private By _stateDropDown = By.Id("id_state");
            private By _stateOption = By.XPath("//option[@value='1' and contains(text(),'Alabama')]");
            private By _postcodeField = By.Id("postcode");
            private By _mobilePhoneField = By.Id("phone_mobile");
            private By _submitButton = By.Id("submitAccount");

            

            public void SignUp(PersonalInformation info)
            {
                Driver.GetElement(_genderMr).Click();
                Driver.GetElement(_firstNameField).SendKeys(info.FirstName);
                Driver.GetElement(_lastNameField).SendKeys(info.LastName);
                Driver.GetElement(_passwordField).SendKeys(info.Pswd);
                Driver.GetElement(_addressField).SendKeys(info.Address);
                Driver.GetElement(_stateDropDown).Click();
                Driver.GetElement(_stateOption).Click();
                Driver.GetElement(_cityField).SendKeys(info.City);
                Driver.GetElement(_postcodeField).SendKeys(info.PostCode);
                Driver.GetElement(_mobilePhoneField).SendKeys(info.MobilePhone);
                Driver.GetElement(_submitButton).Click();
            }

    }
}
