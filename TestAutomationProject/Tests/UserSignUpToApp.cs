using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Models;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.Tests
{
    class UserSignUpToApp : BaseTest
    {
        private PersonalInformation _info;
        

        [SetUp]
            public void SetUp()
            {
                Pages.MainPage.NavigateToMainPage();
            }
        //
            [Test]
            public void UserCanSignUp()
            {
            _info = new PersonalInformation();
            _info.FirstName = TestData.PositiveUser.First_name;
            _info.LastName = TestData.PositiveUser.Last_name;
            _info.Pswd = TestData.PositiveUser.Password;
            _info.Address = TestData.PositiveUser.Password;
            _info.City = TestData.PositiveUser.City;
            _info.PostCode = TestData.PositiveUser.PostCode;
            _info.MobilePhone = TestData.PositiveUser.MobilePhone;
            Pages.MainPage.NavigateToSignInPage();
            Pages.SignInPage.SignUp(TestData.PositiveUser.Mail);
            Pages.CreateAccountPage.SignUp(_info);
            Assert.That(Pages.SignInPage.UserName, Is.EqualTo(TestData.PositiveUser.First_name + " " + TestData.PositiveUser.Last_name));
            }
           

            [TearDown]
            public void TierDown()
            {
                Pages.MainPage.LogOut();
            }
    }
}
