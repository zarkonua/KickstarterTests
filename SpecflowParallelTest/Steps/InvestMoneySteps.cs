using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowParallelTest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowParallelTest
{
    [Binding]
    public class InvestMoneySteps
    {
        private IWebDriver _driver;
        ProjectPage page;
        int collectedSumm;
        dynamic data;

        public InvestMoneySteps(IWebDriver driver)
        {
            _driver = driver;
            page = new ProjectPage(driver);
        }

        [Given(@"I navigate to project1")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/project/1.html");
        }

        [Given(@"I click invest custom amount button")]
        public void GivenIClickInvestCustom()
        {
            collectedSumm = page.GetCollectedSumm();
            page.ClickInvestCustomButton();
        }

        [Given(@"I enter cardholder name card number and summ")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            data = table.CreateDynamicInstance();
            page.InvestCustom(data.CardHolderName, data.CardNum.ToString(), data.Summ.ToString());
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmit()
        {
            page.ClickSubmitButton();
        }

        [Then(@"I should see money added into Collected column")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            page.ClickBackButton();
            _driver.Navigate().Refresh();
            int collected = page.GetCollectedSumm();
            Assert.AreEqual((collectedSumm + data.Summ), collected);
        }

    }
}
