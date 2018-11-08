using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.POM
{
    public class GooglePage
    {
        private IWebDriver _driver;

        public GooglePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox;

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement SearchButton;

        public void OpenPage()
        {
            _driver.Url = "http://www.google.com";

        }
        public void FillSearchBox(string text)
        {
            SearchBox.SendKeys(text);
        }

        public bool IsLoaded()
        {
            return SearchBox != null && SearchButton != null;
        }

        public GoogleResultsPage ClickSearchButton()
        {
            SearchButton.Submit();
            return new GoogleResultsPage(_driver);
        }
    }
}
