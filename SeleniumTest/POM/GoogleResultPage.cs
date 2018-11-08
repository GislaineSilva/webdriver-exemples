using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.POM
{
    public class GoogleResultsPage
    {
        private IWebDriver _driver;

        public GoogleResultsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "vn1s0p1c0")]
        public IWebElement FirstLink;
    }
}
