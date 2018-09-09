using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace QADoclerHomeworkTiborFarkas
{
    [Binding]
    public class DoclerPageTestSteps
    {
        public static IWebDriver driver;
        private HomePageObject home;
        private FormPageObject form;

        public DoclerPageTestSteps()
        {
            home = new HomePageObject();
            form = new FormPageObject();
        }

        [BeforeTestRun]
        private static void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            driver = new ChromeDriver(options);
        }

        [AfterTestRun]
        private static void TearDown()
        {
            driver.Close();
        }

        [Given(@"Docler webpage is opened")]
        public void GivenDockerWebpageIsOpened()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com");
        }

        [When(@"I open ""(.*)"" site")]
        public void WhenIOpenSite(string site)
        {
            switch (site)
            {
                case "Home":
                    home.HomeBtn.Click();
                    break;
                case "Form":
                    home.FormBtn.Click();
                    break;
                case "Error":
                    home.ErrorBtn.Click();
                    break;
            }
        }

        [When(@"I click on the UI Testing button")]
        public void WhenIClickOnTheUITestingButton()
        {
            form.UITestingBtn.Click();
        }

        [When(@"I enter ""(.*)"" and click on the submit button")]
        public void WhenIEnterJohnAndClickOnTheSubmitButton(string name)
        {
            form.Input.SendKeys(name);
            //form.Input.Submit();
            form.SubmitBtn.Click();
        }

        [Then(@"A form is visible with one input field and a submit button")]
        public void ThenAFormIsVisibleWithOneInputFieldAndASubmitButton()
        {
            Assert.IsTrue(form.Input.Displayed && form.Input.Enabled, "Input field is not visible in the form");
            Assert.IsTrue(form.SubmitBtn.Displayed && form.SubmitBtn.Enabled, "Submit button is not visible in the form");
        }

        [Then(@"The title should be: UI Testing Site")]
        public void ThenTheTitleShouldBeUITestingSite()
        {
            Assert.AreEqual(driver.Title, "UI Testing Site");
        }

        [Then(@"Company logo is visible")]
        public void ThenCompanyLogoIsVisible()
        {
            Assert.IsTrue(home.CompanyLogo.Displayed && home.CompanyLogo.Enabled, "Company logo is not displayed");
        }

        [Then(@"Got 404 HTTP response code")]
        public void ThenGotHTTPResponseCode()
        {
            Assert.True(driver.Title.Contains("404 Error"));
        }

        [Then(@"The ""(.*)"" page is opened")]
        public void ThenPageIsOpened(string site)
        {
            switch(site)
            {
                case "Home":
                    Assert.AreEqual(driver.Url, "http://uitest.duodecadits.com/");
                    break;
                case "Form":
                    Assert.AreEqual(driver.Url, "http://uitest.duodecadits.com/form.html");
                    break;
                case "Hello":
                    Assert.True(driver.Url.Contains("http://uitest.duodecadits.com/hello.html"));
                    break;
            }
        }

        [Then(@"The ""(.*)"" menu item is active")]
        public void ThenMenuItemIsActive(string site)
        {
            switch(site)
            {
                case "Home":
                    Assert.AreEqual(home.HomeBtn.GetAttribute("class"), "active");
                    break;
                case "Form":
                    Assert.AreEqual(home.FormBtn.GetAttribute("class"), "active");
                    break;
            }
        }


        [Then(@"""(.*)"" text visible in ""(.*)"" tag")]
        public void ThenTextVisibleInTag(string text, string tag)
        {
            switch(tag)
            {
                case "H1":
                    Assert.AreEqual(text, home.H1tag.Text);
                    break;
                case "p":
                    Assert.AreEqual(text, home.Ptag.Text);
                    break;
            }
        }

    }
}
