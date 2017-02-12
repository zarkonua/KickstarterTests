
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecflowParallelTest.Pages
{
    class LoginPage
    {

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/form/input[1]")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/form/input[2]")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/form/button")]
        IWebElement btnLogin { get; set; }


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return new HomePage();
        }

    }
}
