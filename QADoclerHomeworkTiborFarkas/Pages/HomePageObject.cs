using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace QADoclerHomeworkTiborFarkas
{
    class HomePageObject: CommonPageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(DoclerPageTestSteps.driver, this);
        }

        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement H1tag { get; set; }

        [FindsBy(How = How.TagName, Using = "p")]
        public IWebElement Ptag { get; set; }
    }
}
