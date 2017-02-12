using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecflowParallelTest.Pages;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class LoginSteps
    {

        private IWebDriver _driver;
        LoginPage page;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            page = new LoginPage(driver);
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/login.html");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            page.Login(data.UserName, data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            page.ClickLoginButton();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = _driver.FindElement(By.XPath("/html/body/div/div[1]/div/div[2]/ul/li[3]/a"));
                Assert.That(element.Text, Is.Not.Null, "My Account text not found !!!");
        }


    }
}
