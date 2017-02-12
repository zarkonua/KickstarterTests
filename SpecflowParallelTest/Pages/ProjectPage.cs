
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SpecflowParallelTest.Pages
{
    class ProjectPage
    {
        IWebDriver _driver;

        public ProjectPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/button[1]")]
        IWebElement btnInvestCustom { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[2]/form/input[2]")]
        IWebElement txtCardHolderName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[2]/form/input[3]")]
        IWebElement txtCardNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[2]/form/input[4]")]
        IWebElement txtDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/table[1]/tbody/tr[4]/td[2]")]
        IWebElement txtCollected { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[2]/form/button")]
        IWebElement btnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/button")]
        IWebElement btnBack { get; set; }

        public void InvestCustom(string cardHolderName, string cardNum, string summ)
        {
            Thread.Sleep(1000);
            txtCardHolderName.SendKeys(cardHolderName);
            txtCardNum.SendKeys(cardNum);
            txtDescription.SendKeys(summ);
        }

        public int GetCollectedSumm()
        {
            Thread.Sleep(2000);
            string s = txtCollected.Text;
            Console.Write(s);
            return Int32.Parse(s);
        }

        public ProjectPage ClickInvestCustomButton()
        {
            btnInvestCustom.Click();
            return this;
        }

        public ProjectPage ClickSubmitButton()
        {
            btnSubmit.Submit();
            return this;
        }

        public ProjectPage ClickBackButton()
        {
            btnBack.Click();
            return this;
        }

    }
}
