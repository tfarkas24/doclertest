using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QADoclerHomeworkTiborFarkas
{
    class FormPageObject : CommonPageObject
    {
        public FormPageObject()
        {
            PageFactory.InitElements(DoclerPageTestSteps.driver, this);
        }

        [FindsBy(How = How.TagName, Using = "input")]
        public IWebElement Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[button]")]
        public IWebElement SubmitBtn { get; set; }
    }
}
