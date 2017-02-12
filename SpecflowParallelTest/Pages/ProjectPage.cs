
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[2]/form/button")]
        IWebElement btnSubmit { get; set; }

        public void InvestCustom(string cardHolderName, string cardNum, string summ)
        {
            bool s = txtCardHolderName.Displayed;
            Thread.Sleep(1000);
            txtCardHolderName.SendKeys(cardHolderName);
            txtCardNum.SendKeys(cardNum);
            txtDescription.SendKeys(summ);
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

    }
}
