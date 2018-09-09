using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace QADoclerHomeworkTiborFarkas
{
    public class CommonPageObject
    {
        public CommonPageObject()
        {
            PageFactory.InitElements(DoclerPageTestSteps.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//li[a[.='Home']]")]
        public IWebElement HomeBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[a[.='Form']]")]
        public IWebElement FormBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[a[.='Error']]")]
        public IWebElement ErrorBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='UI Testing']")]
        public IWebElement UITestingBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@id='dh_logo']")]
        public IWebElement CompanyLogo { get; set; }
    }
}
