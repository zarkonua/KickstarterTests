﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecflowParallelTest.Pages
{
    class HomePage
    {

        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Manage']")]
        IWebElement lnkLoggedInUser { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log off")]
        IWebElement lnkLogoff { get; set; }


        //internal LoginPage ClickLogin()
        //{
        //    lnkLogin.Click();
        //    return GetInstance<LoginPage>();
        }
}

