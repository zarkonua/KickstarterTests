
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecflowParallelTest.Pages
{
    class UserAccountPage
    {

        public UserAccountPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/button")]
        IWebElement btnInvestCustom { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"name\"]")]
        IWebElement txtPrName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"description\"]")]
        IWebElement txtDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"goal\"]")]
        IWebElement txtGoal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"daysLeft\"]")]
        IWebElement txtDaysLeft { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"history\"]")]
        IWebElement txtPrHistory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"linksToVideo\"]")]
        IWebElement txtLinksToVideo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"myModal\"]/div/div/div[3]/input")]
        IWebElement btnSubmit { get; set; }

        public void CreateProject(string userName, string password)
        {
            txtPrName.SendKeys(userName);
            txtDescription.SendKeys(password);
            txtGoal.SendKeys(password);
            txtDaysLeft.SendKeys(password);
            txtPrHistory.SendKeys(password);
            txtLinksToVideo.SendKeys(password);
        }


        public void ClickCreateProjectButton()
        {
            btnInvestCustom.Submit();
        }

        public void ClickSubmitButton()
        {
            btnSubmit.Submit();
        }

    }
}
